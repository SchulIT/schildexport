using SchulIT.SchildExport.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public interface IExporter
    {
        void Configure(string connectionString, bool enableTrace);

        Task<SchoolInfo> GetSchoolInfoAsync();

        Task<List<Teacher>> GetTeachersAsync();

        Task<List<Student>> GetStudentsAsync();

        Task<List<Student>> GetStudentsAsync(int[] status);

        Task<List<Student>> GetStudentsAsync(DateTime leaveDateThreshold);

        Task<List<Student>> GetStudentsAsync(int[] status, DateTime? leaveDateThreshold);

        Task<List<Subject>> GetSubjectsAsync();

        Task<List<Grade>> GetGradesAsync();

        Task<List<StudyGroup>> GetStudyGroupsAsync(IEnumerable<Student> currentStudents, short year, short section);

        Task<List<Tuition>> GetTuitionsAsync(IEnumerable<Student> currentStudents, short year, short section);

        Task<List<PrivacyCategory>> GetPrivacyCategoriesAsync();

        Task<List<StudentPrivacy>> GetStudentPrivaciesAsync(IEnumerable<Student> currentStudents);
    }
}