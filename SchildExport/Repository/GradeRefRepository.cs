using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class GradeRefRepository
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public List<GradeRef> FindAll(SchildNRWConnection connection)
        {
            return connection.Versetzung
                .Select(x => new GradeRef { Id = x.Id, Name = x.Klasse, IsVisible = sichtbarBooleanConverter.Convert(x.Sichtbar) })
                .ToList();
        }
    }
}
