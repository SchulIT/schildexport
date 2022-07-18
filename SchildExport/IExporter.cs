using SchulIT.SchildExport.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public interface IExporter
    {
        [Obsolete("Use Configure(string, string, string) which enables you to specify a ")]
        void Configure(string connectionString, bool enableTrace);

        /// <summary>
        /// Konfiguriert den Exporter
        /// </summary>
        /// <param name="connectionProvider">Gibt</param>
        /// <param name="connectionString">Gibt die Verbindungszeichenfolge an.</param>
        /// <param name="enableTrace"></param>
        void Configure(ConnectionProvider connectionProvider, string connectionString, bool enableTrace);

        Task<SchoolInfo> GetSchoolInfoAsync();

        Task<List<Teacher>> GetTeachersAsync();

        Task<List<Student>> GetStudentsAsync();

        Task<List<Student>> GetStudentsAsync(int[] status);

        Task<List<Student>> GetStudentsAsync(DateTime leaveDateThreshold);

        Task<List<Student>> GetStudentsAsync(int[] status, DateTime? leaveDateThreshold);

        Task<List<Student>> GetStudentsAsync(short year, short section);

        Task<List<Subject>> GetSubjectsAsync();

        Task<List<Grade>> GetGradesAsync();

        Task<List<Grade>> GetGradesAsync(short year, short section);

        Task<List<StudyGroup>> GetStudyGroupsAsync(IEnumerable<Student> currentStudents, short year, short section);

        Task<List<Tuition>> GetTuitionsAsync(IEnumerable<Student> currentStudents, short year, short section);

        Task<List<PrivacyCategory>> GetPrivacyCategoriesAsync();

        Task<List<StudentPrivacy>> GetStudentPrivaciesAsync(IEnumerable<Student> currentStudents);
    }
}