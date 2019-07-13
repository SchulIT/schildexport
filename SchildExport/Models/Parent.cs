using System;
using System.Collections.Generic;
using System.Text;

namespace SchulIT.SchildExport.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
    }
}
