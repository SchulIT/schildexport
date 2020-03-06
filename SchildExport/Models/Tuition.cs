using System.Collections.Generic;

namespace SchulIT.SchildExport.Models
{
    public class Tuition
    {
        public StudyGroupRef StudyGroupRef { get; set; }

        public SubjectRef SubjectRef { get; set; }

        public TeacherRef TeacherRef { get; set; }

        public ICollection<TeacherRef> AdditionalTeachersRef { get; set; }
    }
}
