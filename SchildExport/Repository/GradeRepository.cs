using LinqToDB;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class GradeRepository
    {
        private TeacherRefRepository teacherRefRepository;

        public GradeRepository(TeacherRefRepository teacherRefRepository)
        {
            this.teacherRefRepository = teacherRefRepository;
        }

        public List<Grade> FindAll(SchildNRWConnection connection, IConverter<Versetzung, Grade> converter)
        {
            var teachers = teacherRefRepository.FindAll(connection);
            var versetzungGradeConverter = (converter as VersetzungGradeConverter);
            versetzungGradeConverter?.SetTeachers(teachers);

            return connection
                .Versetzung
                .Select(x => converter.Convert(x))
                .ToList();
        }

        public List<Grade> FindAll(SchildNRWConnection connection, IConverter<Versetzung, Grade> converter, short year, short section)
        {
            var teachers = teacherRefRepository.FindAll(connection);
            var grades = FindAll(connection, converter)
                .ToDictionary(x => x.Name);

            // Reset teachers
            foreach(var grade in grades.Values)
            {
                grade.SubstituteTeacher = null;
                grade.Teacher = null;
            }

            // Repopulate teachers (based on the given year/section)
            var students = (from s in connection.SchuelerLernabschnittsdaten
                            where s.Abschnitt == section && s.Jahr == year
                            select s).Distinct();

            foreach(var student in students)
            {
                if(grades.ContainsKey(student.Klasse) == false)
                {
                    continue;
                }

                var grade = grades[student.Klasse];

                if(grade.Teacher != null || grade.SubstituteTeacher != null)
                {
                    continue;
                }

                grade.Teacher = teachers.FirstOrDefault(x => x.Acronym == student.KlassenLehrer);
                grade.SubstituteTeacher = teachers.FirstOrDefault(x => x.Id == student.StvKlassenlehrerId);
            }

            return grades.Values.ToList();
        }
    }
}
