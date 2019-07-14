using Newtonsoft.Json;
using SchulIT.SchildExport;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using System;
using System.Threading.Tasks;

namespace SchildExport.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter connection string:");
            var connectionString = System.Console.ReadLine();

            WriteLine("Connecting to database...");
            var schildExport = new Exporter();
            schildExport.Configure(DatabaseType.MSSQL,connectionString);

            bool isExited = false;

            while(!isExited)
            {
                // MENU
                WriteLine("Choose what to export:");
                WriteLine("[0] quit");
                WriteLine("[1] students");
                WriteLine("[2] parents");
                WriteLine("[3] teachers");
                WriteLine("[4] subjects");
                WriteLine("[5] grades");
                WriteLine("[6] teacher subjects");
                WriteLine("[7] courses");
                WriteLine("[8] school info");

                int choice = ReadInt();

                if (choice < 0 || choice > 6)
                {
                    WriteError("Please chose a valid option.");
                }

                switch(choice)
                {
                    case 0:
                        isExited = true;
                        break;

                    case 1:
                        WriteLine("Exporting students...");
                        WriteJson(GetResult(schildExport.GetStudentsAsync(new CustomSchuelerStudentConverter(), new VersetzungGradeConverter(), new KLehrerNullConverter())));
                        break;

                    case 2:
                        WriteLine("Exporting parents...");
                        WriteJson(GetResult(schildExport.GetParentsAsync()));
                        break;

                    case 3:
                        WriteLine("Exporting teachers...");
                        WriteJson(GetResult(schildExport.GetTeachersAsync(true, new CustomKLehrerTeacherConverter())));
                        break;

                    case 4:
                        WriteLine("Exporting subjects...");
                        WriteJson(GetResult(schildExport.GetSubjectsAsync()));
                        break;

                    case 5:
                        WriteLine("Exporting grades...");
                        WriteJson(GetResult(schildExport.GetGradesAsync()));
                        break;

                    case 6:
                        WriteLine("Exporting teacher grades...");
                        WriteJson(GetResult(schildExport.GetTeacherSubjectsAsync()));
                        break;

                    case 7:
                        WriteLine("Get current academic year info...");
                        var info = GetResult(schildExport.GetSchoolInfoAsync());
                        WriteLine($"Acamdemic year: {info.CurrentYear}");
                        WriteLine($"Acamdemic year section: {info.CurrentSection}");

                        WriteJson(GetResult(schildExport.GetCoursesAsync(info.CurrentYear, info.CurrentSection)));
                        break;

                    case 8:
                        WriteLine("Get current academic year info...");
                        WriteJson(GetResult(schildExport.GetSchoolInfoAsync()));
                        break;
                }
            }

            WriteLine("Bye");
        }

        private static int ReadInt()
        {
            while (true)
            {
                string input = System.Console.ReadLine();
                int number;

                if (int.TryParse(input, out number) == false)
                {
                    WriteError("Please input a valid number. Try again.");
                }
                else
                {
                    return number;
                }
            }
        }

        private static void WriteLine(string line)
        {
            System.Console.WriteLine(line);
        }

        private static void WriteError(string line)
        {
            System.Console.Error.WriteLine(line);
        }

        private static void WriteJson(object objectToSerialize)
        {
            WriteLine(JsonConvert.SerializeObject(objectToSerialize));
        }

        private static T GetResult<T>(Task<T> task)
        {
            task.Wait();
            return task.Result;
        }
    }
}
