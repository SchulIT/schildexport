using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class PrivacyCategoryRepository
    {
        public List<PrivacyCategory> FindAll(SchildNRWConnection connection, IConverter<KDatenschutz, PrivacyCategory> converter)
        {
            return connection
                .KDatenschutz
                .Select(x => converter.Convert(x))
                .ToList();
        }
    }
}
