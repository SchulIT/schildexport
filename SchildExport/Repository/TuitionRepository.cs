using LinqToDB;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class TuitionRepository
    {
        private StudyGroupRepository studyGroupRepository;
        private TeacherRefRepository teacherRefRepository;
        private SubjectRefRepository subjectRefRepository;

        public TuitionRepository(StudyGroupRepository studyGroupRepository, TeacherRefRepository teacherRefRepository, SubjectRefRepository subjectRefRepository)
        {
            this.studyGroupRepository = studyGroupRepository;
            this.teacherRefRepository = teacherRefRepository;
            this.subjectRefRepository = subjectRefRepository;
        }

        public List<Tuition> FindAll(SchildNRWConnection connection, short year, short section)
        {
            var studyGroups = studyGroupRepository.FindAll(connection, year, section);
            var teacherRefs = teacherRefRepository.FindAll(connection);
            var subjectRefs = subjectRefRepository.FindAll(connection);
            var additionalTeachers = (from l in connection.KursLehrer
                                      group l by l.KursId into x
                                      select new
                                      {
                                          CourseId = x.Key,
                                          TeacherIds = x.ToList()
                                      }).ToList();


            var results = from a in connection.SchuelerLernabschnittsdaten
                          from l in connection.SchuelerLeistungsdaten.InnerJoin(sld => sld.AbschnittId == a.Id)
                          from c in connection.Kurse.Where(x => x.Id == l.KursId).DefaultIfEmpty()
                          where a.Jahr == year && a.Abschnitt == section
                          select new
                          {
                              CourseId = l.KursId,
                              CourseName = c.KurzBez,
                              SubjectId = l.FachId,
                              TeacherAcronym = l.FachLeher,
                              AdditionalTeacher = l.Zusatzkraft,
                              Grade = a.Klasse
                          };

            var tuitions = new List<Tuition>();

            // Klassenunterrichte
            tuitions.AddRange(
                results
                    .Where(x => x.CourseId == null)
                    .GroupBy(x => new { x.SubjectId, x.TeacherAcronym, x.AdditionalTeacher, x.Grade })
                    .ToList()
                    .Select(x =>
                    {
                        var gradeNames = x.Select(y => y.Grade).Distinct().ToList();
                        var additionalTuitionTeachers = new List<TeacherRef>();

                        // Add additional teacher (if present)
                        if (x.Key.AdditionalTeacher != null)
                        {
                            additionalTuitionTeachers.Add(teacherRefs.FirstOrDefault(t => t.Acronym == x.Key.AdditionalTeacher));
                        }

                        /**
                         * study group matches if:
                         * 1. Type equals Grade
                         * 2. Grades are same (Part 2+3) -> https://stackoverflow.com/a/22173821
                         */
                        var studyGroup = studyGroups.FirstOrDefault(sg => sg.Type == StudyGroupType.Grade && sg.Grades.Select(g => g.Name).All(gradeNames.Contains) && sg.Grades.Count == gradeNames.Count);

                        return new Tuition
                        {
                            TeacherRef = teacherRefs.FirstOrDefault(t => t.Acronym == x.Key.TeacherAcronym),
                            SubjectRef = subjectRefs.FirstOrDefault(s => s.Id == x.Key.SubjectId),
                            StudyGroupRef = studyGroup,
                            AdditionalTeachersRef = additionalTuitionTeachers.Where(t => t != null).ToList()
                        };
                    })
            );

            // Kursunterrichte
            tuitions.AddRange(
                results
                    .Where(x => x.CourseId != null)
                    .GroupBy(x => new { x.CourseId, x.CourseName, x.SubjectId, x.TeacherAcronym, x.AdditionalTeacher })
                    .ToList()
                    .Select(x =>
                    {
                        var gradeNames = x.Select(y => y.Grade).Distinct().ToList();
                        var additionalTuitionTeachers = new List<TeacherRef>();

                        // Add additional teachers
                        var teachers = additionalTeachers.FirstOrDefault(y => y.CourseId == x.Key.CourseId);

                        if (teachers != null)
                        {
                            foreach (var teacher in teachers.TeacherIds)
                            {
                                additionalTuitionTeachers.Add(teacherRefs.FirstOrDefault(t => t.Id == teacher.LehrerId));
                            }
                        }

                        var studyGroup = studyGroups.FirstOrDefault(sg => sg.Type == StudyGroupType.Course && sg.Id == x.Key.CourseId);

                        return new Tuition
                        {
                            TeacherRef = teacherRefs.FirstOrDefault(t => t.Acronym == x.Key.TeacherAcronym),
                            SubjectRef = subjectRefs.FirstOrDefault(s => s.Id == x.Key.SubjectId),
                            StudyGroupRef = studyGroup,
                            AdditionalTeachersRef = additionalTuitionTeachers.Where(t => t != null).ToList()
                        };
                    })
            );

            return tuitions;
        }
    }
}
