using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class SubjectRepository
    {
        public List<Subject> FindAll(SchildNRWConnection connection, IConverter<EigeneSchuleFaecher, Subject> converter)
        {
            return connection
                .EigeneSchuleFaecher
                .Select(x => converter.Convert(x))
                .ToList();
        }
    }
}
