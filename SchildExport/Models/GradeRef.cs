namespace SchulIT.SchildExport.Models
{
    public class GradeRef : IHasVisibility
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsVisible { get; set; }
    }
}
