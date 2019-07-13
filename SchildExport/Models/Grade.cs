namespace SchulIT.SchildExport.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Teacher Teacher { get; set; }

        public Teacher SubstitudeTeacher { get; set; }
    }
}
