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

        public StudyGroupRepository(GradeRefRepository gradeRefRepository)
        {
            this.gradeRefRepository = gradeRefRepository;
        }

        public List<StudyGroup> FindAll(SchildNRWConnection connection, short year, short section)
        {
            var gradeRefs = gradeRefRepository.FindAll(connection);

            var studyGroups = new List<StudyGroup>();
            studyGroups.AddRange(GetGradeStudyGroups(connection, gradeRefs, year, section));
            studyGroups.AddRange(GetCourseStudyGroups(connection, gradeRefs, year, section));

            return studyGroups;
        }

        private List<StudyGroup> GetGradeStudyGroups(SchildNRWConnection connection, IEnumerable<GradeRef> gradeRefs, short year, short section)
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
                    if (!studentIds.Contains(data.SchuelerId))
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

        private List<StudyGroup> GetCourseStudyGroups(SchildNRWConnection connection, IEnumerable<GradeRef> gradeRefs, short year, short section)
        {
            var results = from a in connection.SchuelerLernabschnittsdaten
                          from l in connection.SchuelerLeistungsdaten.InnerJoin(sld => sld.AbschnittId == a.Id)
                          from c in connection.Kurse.InnerJoin(k => k.Id == l.KursId)
                          where a.Jahr == year && a.Abschnitt == section && l.Kursart != GradeStudyGroupMembershipType
                          select new
                          {
                              CourseId = l.KursId,
                              CourseName = c.KurzBez,
                              SubjectId = l.FachId,
                              TeacherAcronym = l.FachLeher,
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

                        if (!studentIds.Contains(m.Membership.StudentId))
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