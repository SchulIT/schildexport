using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class StudentRepository : Repository<Schueler, Student>
    {
        public override Task<List<Student>> FindAllAsync(SchildNRWContext context, IConverter<Schueler, Student> converter)
        {
            return GetEntitiesAsync(context.Schueler, converter);
        }
    }
}
