namespace SchulIT.SchildExport.Models
{
    public class Grade : GradeRef, IHasVisibility
    {
        public TeacherRef Teacher { get; set; }

        public TeacherRef SubstituteTeacher { get; set; }
    }
}
