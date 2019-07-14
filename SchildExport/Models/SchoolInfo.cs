namespace SchulIT.SchildExport.Models
{
    public class SchoolInfo
    {
        public string SchoolId { get; set; }

        public string Name { get; set; }

        public int CurrentYear { get; set; }

        public int CurrentSection { get; set; }

        public int NumSections { get; set; }

        public string[] SectionLabels { get; set; }
    }
}
