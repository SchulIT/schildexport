using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class Course
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int Section { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public Subject Subject { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<StudentCourseMembership> Students { get; } = new List<StudentCourseMembership>();

        public ICollection<Grade> Grades { get; } = new List<Grade>();

        public ICollection<Teacher> AdditionalTeacher { get; } = new List<Teacher>();
    }
}
