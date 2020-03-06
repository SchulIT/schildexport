using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class StudyGroup : StudyGroupRef
    {
        public StudyGroupType Type { get; set; }

        public ICollection<GradeRef> Grades { get; set; } = new List<GradeRef>();

        public ICollection<StudyGroupMembership> Memberships { get; set; } = new List<StudyGroupMembership>();
    }
}
