using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Linq;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    public class SchoolInfoRepository : IRepository<EigeneSchule, SchoolInfo>
    {
        public async Task<List<SchoolInfo>> FindAllAsync(SchildNRWContext context, IConverter<EigeneSchule, SchoolInfo> converter)
        {
            var entity = await context.EigeneSchule.FromSql("SELECT * FROM dbo.EigeneSchule").ToListAsync().ConfigureAwait(false);
            var dataTransferObjects = await entity.SelectAsync(x => converter.Convert(x)).ConfigureAwait(false);

            return await dataTransferObjects.ToListAsync().ConfigureAwait(false);
        }
    }
}
