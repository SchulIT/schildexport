using System;

namespace SchulIT.SchildExport.Models
{
    public class Student : StudentRef
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public bool IsFullage { get; set; }

        public DateTime? Birthday { get; set; }

        public Gender Gender { get; set; }

        public GradeRef Grade { get; set; }

        public string Status { get; set; }

        public DateTime? LeaveDate { get; set; }
    }
}
