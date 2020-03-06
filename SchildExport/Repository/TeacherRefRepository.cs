using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class TeacherRefRepository
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public List<TeacherRef> FindAll(SchildNRWConnection connection)
        {
            return connection.KLehrer
                .Select(x => new TeacherRef { Id = x.Id, Acronym = x.Kuerzel, IsVisible = sichtbarBooleanConverter.Convert(x.Sichtbar) })
                .ToList();
        }
    }
}
