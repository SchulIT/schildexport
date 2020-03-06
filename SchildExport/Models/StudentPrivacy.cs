using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class StudentPrivacy
    {
        public StudentRef Student { get; set; }

        public ICollection<PrivacyCategoryRef> Approved { get; set; }

        public ICollection<PrivacyCategoryRef> NotApproved { get; set; }
    }
}
