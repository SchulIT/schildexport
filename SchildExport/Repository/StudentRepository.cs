using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class StudentRepository
    {

        private GradeRefRepository gradeRefRepository;

        public StudentRepository(GradeRefRepository gradeRefRepository)
        {
            this.gradeRefRepository = gradeRefRepository;
        }

        public List<Student> FindAll(SchildNRWConnection connection, IConverter<Schueler, Student> converter, int[] status, DateTime? leaveDate)
        {
            var grades = gradeRefRepository.FindAll(connection);
            var schuelerStudentConverter = converter as SchuelerStudentConverter;
            schuelerStudentConverter?.SetGrades(grades);

            var students = connection.Schueler.ToList();

            if(status != null && status.Length > 0)
            {
                students = students.Where(x => status.Contains((int)x.Status)).ToList();
            }

            if (leaveDate != null)
            {
                students = students.Where(x => x.Entlassdatum == null || x.Entlassdatum >= leaveDate).ToList();
            }

            return students
                .Select(x => converter.Convert(x))
                .ToList();
        }
    }
}
