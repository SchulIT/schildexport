using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class SubjectRefRepository
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public List<SubjectRef> FindAll(SchildNRWConnection connection)
        {
            return connection
                .EigeneSchuleFaecher
                .Select(x => new SubjectRef { Id = x.Id, Abbreviation = x.FachKrz, IsVisible = sichtbarBooleanConverter.Convert(x.Sichtbar) })
                .ToList();
        }
    }
}
