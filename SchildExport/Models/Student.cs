using System;

namespace SchulIT.SchildExport.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public DateTime? Birthday { get; set; }

        public Gender Gender { get; set; }

        public Grade Grade { get; set; }
    }
}
