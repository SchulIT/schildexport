namespace SchulIT.SchildExport.Repository
{
    static class RepositoryFactory
    {
        public static SchoolInfoRepository CreateSchoolInfoRepository()
        {
            return new SchoolInfoRepository();
        }

        public static TeacherRepository CreateTeacherRepository()
        {
            return new TeacherRepository(CreateSubjectRefRepository());
        }

        public static TeacherRefRepository CreateTeacherRefRepository()
        {
            return new TeacherRefRepository();
        }

        public static StudentRepository CreateStudentRepository()
        {
            return new StudentRepository(CreateGradeRefRepository());
        }

        public static GradeRefRepository CreateGradeRefRepository()
        {
            return new GradeRefRepository();
        }

        public static GradeRepository CreateGradeRepository()
        {
            return new GradeRepository(CreateTeacherRefRepository());
        }

        public static SubjectRepository CreateSubjectRepository()
        {
            return new SubjectRepository();
        }

        public static SubjectRefRepository CreateSubjectRefRepository()
        {
            return new SubjectRefRepository();
        }

        public static StudyGroupRepository CreateStudyGroupRepositoy()
        {
            return new StudyGroupRepository(CreateGradeRefRepository(), CreateSubjectRefRepository(), CreateStudentRepository());
        }

        public static TuitionRepository CreateTuitionRepository()
        {
            return new TuitionRepository(CreateStudyGroupRepositoy(), CreateTeacherRefRepository(), CreateSubjectRefRepository());
        }

        public static PrivacyCategoryRepository CreatePrivacyCategoryRepository()
        {
            return new PrivacyCategoryRepository();
        }

        public static StudentPrivacyRepository CreateStudentPrivacyRepository()
        {
            return new StudentPrivacyRepository();
        }
    }
}
