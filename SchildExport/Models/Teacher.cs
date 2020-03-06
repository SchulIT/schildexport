using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class Teacher : TeacherRef
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Title { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public ICollection<SubjectRef> Subjects { get; set; }

        public ICollection<TeacherSectionData> SectionData { get; set; }
    }
}
