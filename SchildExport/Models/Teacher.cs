namespace SchulIT.SchildExport.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Title { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }
    }
}
