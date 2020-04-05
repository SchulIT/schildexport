using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Repository
{
    class StudentPrivacyRepository
    {
        private char ApprovedChar = '+';
        private char NotApprovedChar = '-';

        public List<StudentPrivacy> FindAll(SchildNRWConnection connection, IEnumerable<Student> currentStudents)
        {
            var currentStudentIds = currentStudents.Select(x => x.Id).Distinct().ToList();

            return connection.SchuelerDatenschutz
                .GroupBy(x => x.SchuelerId)
                .ToList()
                .Select(x =>
                {
                    return new StudentPrivacy
                    {
                        Student = new StudentRef { Id = x.Key },
                        Approved = x.Where(y => y.Status == ApprovedChar).Select(y => new PrivacyCategoryRef { Id = y.DatenschutzId }).ToList(),
                        NotApproved = x.Where(y => y.Status == NotApprovedChar).Select(y => new PrivacyCategoryRef { Id = y.DatenschutzId }).ToList()
                    };
                })
                .Where(x => currentStudentIds.Contains(x.Student.Id))
                .ToList();
        }
    }
}
