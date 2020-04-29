using LinqToDB;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class StudyGroupRepository
    {
        private const string GradeStudyGroupMembershipType = "PUK";

        private GradeRefRepository gradeRefRepository;
        private SubjectRefRepository subjectRefRepository;

        public StudyGroupRepository(GradeRefRepository gradeRefRepository, SubjectRefRepository subjectRefRepository)
        {
            this.gradeRefRepository = gradeRefRepository;
            this.subjectRefRepository = subjectRefRepository;
        }

        public List<StudyGroup> FindAll(SchildNRWConnection connection, IEnumerable<Student> students, short year, short section)
        {
            var gradeRefs = gradeRefRepository.FindAll(connection);
            var currentStudentIds = students.Select(x => x.Id).Distinct().ToList();

            var studyGroups = new List<StudyGroup>();
            var gradeStudyGroups = GetGradeStudyGroups(connection, gradeRefs, currentStudentIds, year, section);
            studyGroups.AddRange(gradeStudyGroups);
            studyGroups.AddRange(GetRemainingGradeStudyGroups(gradeStudyGroups, gradeRefs, students));
            
            studyGroups.AddRange(GetCourseStudyGroups(connection, gradeRefs, currentStudentIds, year, section));

            return studyGroups;
        }

        private List<StudyGroup> GetRemainingGradeStudyGroups(List<StudyGroup> existingStudyGroups, List<GradeRef> gradeRefs, IEnumerable<Student> students)
        {
            var studyGroups = new List<StudyGroup>();

            var existingGrades = existingStudyGroups.Select(x => x.Grades.FirstOrDefault()).Where(x => x != null).Select(x => x.Id);

            foreach(var gradeRef in gradeRefs)
            {
                if (existingGrades.Contains(gradeRef.Id))
                {
                    continue;
                }

                var studyGroup = new StudyGroup
                {
                    Id = gradeRef.Id,
                    Name = gradeRef.Name,
                    Type = StudyGroupType.Grade,
                    Grades = new List<GradeRef> { gradeRef }
                };

                foreach(var student in students.Where(x => x.Grade != null && x.Grade.Id == gradeRef.Id))
                {
                    studyGroup.Memberships.Add(new StudyGroupMembership
                    {
                        Student = student,
                        Type = null
                    });
                }

                if (studyGroup.Memberships.Count > 0)
                {
                    studyGroups.Add(studyGroup);
                }
            }

            return studyGroups;
        }

        private List<StudyGroup> GetGradeStudyGroups(SchildNRWConnection connection, IEnumerable<GradeRef> gradeRefs, IEnumerable<int> currentStudentIds, short year, short section)
        {
            var results = from a in connection.SchuelerLernabschnittsdaten
                          from l in connection.SchuelerLeistungsdaten.InnerJoin(sld => sld.AbschnittId == a.Id)
                          where a.Jahr == year && a.Abschnitt == section && l.Kursart == GradeStudyGroupMembershipType
                          group a by a.Klasse into x
                          select new
                          {
                              Grade = x.Key,
                              StudentData = x.ToList()
                          };

            
            var studyGroups = new List<StudyGroup>();

            foreach (var result in results)
            {
                var studyGroup = new StudyGroup
                {
                    Id = null,
                    Name = result.Grade,
                    Type = StudyGroupType.Grade
                };

                var gradeRef = gradeRefs.FirstOrDefault(x => x.Name == result.Grade);

                if (gradeRef != null)
                {
                    studyGroup.Grades.Add(gradeRef);
                }

                // Save already added student IDs
                // TODO: Modify code so we only have distinct memberships?!
                var studentIds = new List<int>();

                foreach (var data in result.StudentData)
                {
                    if (!studentIds.Contains(data.SchuelerId) && currentStudentIds.Contains(data.SchuelerId))
                    {
                        var membership = new StudyGroupMembership
                        {
                            Student = new StudentRef
                            {
                                Id = data.SchuelerId
                            },
                            Type = GradeStudyGroupMembershipType
                        };

                        studyGroup.Memberships.Add(membership);
                        studentIds.Add(data.SchuelerId);
                    }
                }

                studyGroups.Add(studyGroup);
            }

            return studyGroups;
        }

        private List<StudyGroup> GetCourseStudyGroups(SchildNRWConnection connection, IEnumerable<GradeRef> gradeRefs, IEnumerable<int> currentStudentIds, short year, short section)
        {
            var subjectRefs = subjectRefRepository.FindAll(connection);

            var results = from a in connection.SchuelerLernabschnittsdaten
                          from l in connection.SchuelerLeistungsdaten.InnerJoin(sld => sld.AbschnittId == a.Id)
                          from c in connection.Kurse.InnerJoin(k => k.Id == l.KursId)
                          where a.Jahr == year && a.Abschnitt == section && l.Kursart != GradeStudyGroupMembershipType
                          select new
                          {
                              CourseId = l.KursId,
                              CourseName = c.KurzBez,
                              SubjectId = l.FachId,
                              TeacherAcronym = string.IsNullOrEmpty(l.FachLeher) ? null : l.FachLeher,
                              Membership = new
                              {
                                  StudentId = a.SchuelerId,
                                  Grade = a.Klasse,
                                  Type = l.Kursart
                              }
                          };

            return
                results
                .GroupBy(x => new { x.CourseId, x.CourseName, x.SubjectId, x.TeacherAcronym })
                .ToList()
                .Select(y =>
                {
                    var studyGroup = new StudyGroup
                    {
                        Id = y.Key.CourseId,
                        Type = StudyGroupType.Course,
                        Name = y.Key.CourseName
                    };

                    // Save already added student IDs
                    // TODO: Modify code so we only have distinct memberships?!
                    var studentIds = new List<int>();

                    foreach (var m in y)
                    {
                        var gradeRef = gradeRefs.FirstOrDefault(x => x.Name == m.Membership.Grade);
                        if (!studyGroup.Grades.Contains(gradeRef))
                        {
                            studyGroup.Grades.Add(gradeRef);
                        }

                        if (!studentIds.Contains(m.Membership.StudentId) && currentStudentIds.Contains(m.Membership.StudentId))
                        {
                            var membership = new StudyGroupMembership
                            {
                                Student = new StudentRef { Id = m.Membership.StudentId },
                                Type = m.Membership.Type
                            };

                            studyGroup.Memberships.Add(membership);
                            studentIds.Add(m.Membership.StudentId);
                        }
                    }

                    return studyGroup;
                })
                .ToList();
        }
    }
}