using LinqToDB;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class TeacherRepository
    {

        private SubjectRefRepository subjectRefRepository;

        public TeacherRepository(SubjectRefRepository subjectRefRepository)
        {
            this.subjectRefRepository = subjectRefRepository;
        }

        public List<Teacher> FindAll(SchildNRWConnection connection, IConverter<KLehrer, Teacher> converter)
        {
            var subjectRefsDict = subjectRefRepository
                .FindAll(connection)
                .ToDictionary(x => x.Abbreviation);

            var result = from t in connection.KLehrer
                         from a in connection.LehrerAbschnittsdaten.InnerJoin(ad => ad.LehrerId == t.Id)
                         group a by t into x
                         select new
                         {
                             Teacher = x.Key,
                             SectionData = x.ToList()
                         };

            var teachersSubjects = (from t in connection.KLehrer
                                    from l in connection.LehrerLehramtLehrbef.InnerJoin(lb => lb.LehrerId == t.Id)
                                    group l by t into x
                                    select new
                                    {
                                        TeacherId = x.Key.Id,
                                        Subjects = x.ToList()
                                    }).ToList();

            return result
                .ToList()
                .Select(x =>
                {
                    var teacher = x.Teacher;
                    teacher.Abschnittsdaten = x.SectionData.AsEnumerable();
                    return teacher;
                })
                .Select(x => converter.Convert(x))
                .Select(teacher =>
                {
                    teacher.Subjects = teachersSubjects
                        .FirstOrDefault(x => x.TeacherId == teacher.Id)
                        ?.Subjects
                        .Select(x => subjectRefsDict.ContainsKey(x.LehrbefKrz) ? subjectRefsDict[x.LehrbefKrz] : null)
                        .Where(x => x != null)
                        .ToList();

                    if(teacher.Subjects == null)
                    {
                        teacher.Subjects = new List<SubjectRef>();
                    }

                    return teacher;
                })
                .ToList();
        }
    }
}
