using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class TeacherRepository : Repository<KLehrer, Teacher>
    {
        public override Task<List<Teacher>> FindAllAsync(SchildNRWContext context, IConverter<KLehrer, Teacher> converter)
        {
            return GetEntitiesAsync(context.KLehrer, converter);
        }
    }
}
