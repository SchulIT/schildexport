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
    }
}
