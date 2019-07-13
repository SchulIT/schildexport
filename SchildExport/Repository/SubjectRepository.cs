using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class SubjectRepository : Repository<EigeneSchuleFaecher, Subject>
    {
        public override Task<List<Subject>> FindAllAsync(SchildNRWContext context, IConverter<EigeneSchuleFaecher, Subject> converter)
        {
            return GetEntitiesAsync(context.EigeneSchuleFaecher, converter);
        }
    }
}
