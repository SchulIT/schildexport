using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class SchoolInfoRepository
    {
        public SchoolInfo FindOne(SchildNRWConnection connection, IConverter<EigeneSchule, SchoolInfo> converter)
        {
            return converter.Convert(connection.EigeneSchule.FirstOrDefault());
        }
    }
}
