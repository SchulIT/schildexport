using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class GradeRepository : Repository<Versetzung, Grade>
    {
        public override Task<List<Grade>> FindAllAsync(SchildNRWContext context, IConverter<Versetzung, Grade> converter)
        {
            return GetEntitiesAsync(context.Versetzung, converter);
        }
    }
}
