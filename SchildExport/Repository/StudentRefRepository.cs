using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class StudentRefRepository
    {
        public List<StudentRef> FindAll(SchildNRWConnection connection)
        {
            return connection
                .Schueler
                .Select(x => new StudentRef
                {
                    Id = x.Id
                })
                .ToList();

        }
    }
}
