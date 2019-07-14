using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class TeacherRepository : Repository<KLehrer, Teacher>
    {
        private bool onlyVisible;

        public TeacherRepository(bool onlyVisible)
        {
            this.onlyVisible = onlyVisible;
        }

        public override Task<List<Teacher>> FindAllAsync(SchildNRWContext context, IConverter<KLehrer, Teacher> converter)
        {
            var dbSet = context.KLehrer;

            if (onlyVisible == true)
            {
                dbSet.Where(x => x.Sichtbar == "+");
            }

            return GetEntitiesAsync(dbSet, converter);
        }
    }
}
