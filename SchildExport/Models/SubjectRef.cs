namespace SchulIT.SchildExport.Models
{
    public class SubjectRef : IHasVisibility
    {
        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public bool IsVisible { get; set; }
    }
}
