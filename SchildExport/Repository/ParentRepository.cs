using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class ParentRepository : Repository<SchuelerErzAdr, Parent>
    {
        public override Task<List<Parent>> FindAllAsync(SchildNRWContext context, IConverter<SchuelerErzAdr, Parent> converter)
        {
            return GetEntitiesAsync(context.SchuelerErzAdr.Include(x => x.Schueler), converter);
        }
    }
}
