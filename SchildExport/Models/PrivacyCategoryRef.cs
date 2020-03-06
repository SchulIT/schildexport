namespace SchulIT.SchildExport.Models
{
    public class PrivacyCategoryRef : IHasVisibility
    {
        public int Id { get; set; }

        public bool IsVisible { get; set; }
    }
}
