using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    public class TeacherSubjectRepository : IRepository<LehrerLehramtLehrbef, TeacherSubjects>
    {
        private readonly IEnumerable<Teacher> teachers;
        private readonly IEnumerable<Subject> subjects;

        public TeacherSubjectRepository(IEnumerable<Teacher> teachers, IEnumerable<Subject> subjects)
        {
            this.teachers = teachers;
            this.subjects = subjects;
        }

        public async Task<List<TeacherSubjects>> FindAllAsync(SchildNRWContext context, IConverter<LehrerLehramtLehrbef, TeacherSubjects> converter)
        {
            var entities = await context.LehrerLehramtLehrbef.FromSql("SELECT Lehrer_ID,LehrbefKrz FROM dbo.LehrerLehramtLehrbef ORDER BY Lehrer_ID ASC").ToListAsync().ConfigureAwait(false);
            var result = new List<TeacherSubjects>();

            await Task.Run(() =>
            {
                foreach(var entity in entities)
                {
                    var teacher = teachers.FirstOrDefault(t => t.Id == entity.LehrerId);
                    var subject = subjects.FirstOrDefault(s => s.Abbreviation == entity.LehrbefKrz);

                    if(teacher == null || subject == null)
                    {
                        continue;
                    }

                    var lastElement = result.Count > 0 ? result.ElementAt(result.Count - 1) : null;

                    if (lastElement != null && lastElement.Teacher.Id == teacher.Id)
                    {
                        lastElement.Subjects.Add(subject);
                    }
                    else
                    {
                        var teacherSubjects = new TeacherSubjects
                        {
                            Teacher = teacher
                        };
                        teacherSubjects.Subjects.Add(subject);

                        result.Add(teacherSubjects);
                    }
                }
            }).ConfigureAwait(false);

            return result;
        }
    }
}
