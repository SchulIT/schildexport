using System;
using System.Collections.Generic;
using System.Text;

namespace SchulIT.SchildExport.Models
{
    public class StudyGroupRef : IHasVisibility
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool IsVisible { get; set; }

    }
}
