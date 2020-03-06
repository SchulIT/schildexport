namespace SchulIT.SchildExport.Models
{
    public class TeacherRef : IHasVisibility
    {
        public int Id { get; set; }

        public string Acronym { get; set; }

        public bool IsVisible { get; set; }
    }
}
