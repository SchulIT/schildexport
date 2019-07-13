using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class TeacherSubjects
    {
        public Teacher Teacher { get; set; }

        public ICollection<Subject> Subjects { get; } = new List<Subject>();
    }
}
