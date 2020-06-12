using LinqToDB.Data;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using SchulIT.SchildExport.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public class Exporter : IExporter
    {
        public void Configure(string connectionString, bool enableTrace)
        {
            if (enableTrace)
            {
                DataConnection.TurnTraceSwitchOn();
                DataConnection.WriteTraceLine = (message, displayName) => { Console.WriteLine($"{message} {displayName}"); };
            }

            DataConnection.DefaultSettings = new DatabaseSettings(connectionString);
        }

        public Task<List<Grade>> GetGradesAsync() => GetGradesAsync(new VersetzungGradeConverter());

        private Task<List<Grade>> GetGradesAsync(IConverter<Versetzung, Grade> converter)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateGradeRepository();
                    return repository.FindAll(connection, converter);
                }
            });
        }

        public Task<SchoolInfo> GetSchoolInfoAsync() => GetSchoolInfoAsync(new EigeneSchuleSchoolInfoConverter());

        private Task<SchoolInfo> GetSchoolInfoAsync(IConverter<EigeneSchule, SchoolInfo> converter)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateSchoolInfoRepository();
                    return repository.FindOne(connection, converter);
                }
            });
        }

        public Task<List<Student>> GetStudentsAsync() => GetStudentsAsync(null, null);

        public Task<List<Student>> GetStudentsAsync(int[] status) => GetStudentsAsync(status, null);

        public Task<List<Student>> GetStudentsAsync(DateTime leaveDateThreshold) => GetStudentsAsync(null, leaveDateThreshold);

        public Task<List<Student>> GetStudentsAsync(int[] status, DateTime? leaveDateThreshold) => GetStudentsAsync(new SchuelerStudentConverter(), status, leaveDateThreshold);

        private Task<List<Student>> GetStudentsAsync(IConverter<Schueler, Student> converter, int[] status, DateTime? leaveDateThreshold)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateStudentRepository();
                    return repository.FindAll(connection, converter, status, leaveDateThreshold);
                }
            });
        }

        public Task<List<StudyGroup>> GetStudyGroupsAsync(IEnumerable<Student> currentStudents, short year, short section)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateStudyGroupRepositoy();
                    return repository.FindAll(connection, currentStudents, year, section);
                }
            });
        }

        public Task<List<Subject>> GetSubjectsAsync() => GetSubjectsAsync(new EigeneSchueleFaecherSubjectConverter());

        private Task<List<Subject>> GetSubjectsAsync(IConverter<EigeneSchuleFaecher, Subject> converter)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateSubjectRepository();
                    return repository.FindAll(connection, converter);
                }
            });
        }

        public Task<List<Teacher>> GetTeachersAsync() => GetTeachersAsync(new KLehrerTeacherConverter());

        private Task<List<Teacher>> GetTeachersAsync(IConverter<KLehrer, Teacher> converter)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateTeacherRepository();
                    return repository.FindAll(connection, converter);
                }
            });
        }

        public Task<List<Tuition>> GetTuitionsAsync(IEnumerable<Student> currentStudents, short year, short section)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateTuitionRepository();
                    return repository.FindAll(connection, currentStudents, year, section);
                }
            });
        }

        public Task<List<PrivacyCategory>> GetPrivacyCategoriesAsync() => GetPrivacyCategories(new KDatenschutzPrivacyCategoryConverter());

        private Task<List<PrivacyCategory>> GetPrivacyCategories(IConverter<KDatenschutz, PrivacyCategory> converter)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreatePrivacyCategoryRepository();
                    return repository.FindAll(connection, converter);
                }
            });
        }

        public Task<List<StudentPrivacy>> GetStudentPrivaciesAsync(IEnumerable<Student> currentStudents)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateStudentPrivacyRepository();
                    return repository.FindAll(connection, currentStudents);
                }
            });
        }

        public Task<List<Student>> GetStudentsAsync(short year, short section)
        {
            return Task.Run(() =>
            {
                using (var connection = new SchildNRWConnection())
                {
                    var repository = RepositoryFactory.CreateStudentRepository();
                    return repository.FindAll(connection, new SchuelerStudentConverter(), year, section);
                }
            });
        }
    }
}
