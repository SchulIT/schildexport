using Newtonsoft.Json;
using SchulIT.SchildExport;
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
            schildExport.Configure(connectionString, true);

            bool isExited = false;

            while(!isExited)
            {
                // MENU
                WriteLine("Choose what to export:");
                WriteLine("[0] quit");
                WriteLine("[1] students");
                WriteLine("[2] privacy categories");
                WriteLine("[3] student privacies");
                WriteLine("[4] teachers");
                WriteLine("[5] subjects");
                WriteLine("[6] grades");
                WriteLine("[7] study groups");
                WriteLine("[8] tuitions");
                WriteLine("[9] school info");

                int choice = ReadInt();

                if (choice < 0 || choice > 9)
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
                        WriteJson(GetResult(schildExport.GetStudentsAsync()));
                        break;

                    case 2:
                        WriteLine("Exporting privacy categories...");
                        WriteJson(GetResult(schildExport.GetPrivacyCategoriesAsync()));
                        break;

                    case 3:
                        WriteLine("Exporting student privacies");
                        WriteJson(GetResult(schildExport.GetStudentPrivaciesAsync(GetResult(schildExport.GetStudentsAsync()))));
                        break;

                    case 4:
                        WriteLine("Exporting teachers...");
                        WriteJson(GetResult(schildExport.GetTeachersAsync()));
                        break;

                    case 5:
                        WriteLine("Exporting subjects...");
                        WriteJson(GetResult(schildExport.GetSubjectsAsync()));
                        break;

                    case 6:
                        WriteLine("Exporting grades...");
                        WriteJson(GetResult(schildExport.GetGradesAsync()));
                        break;

                    case 7:
                        WriteLine("Get current academic year info...");
                        var info = GetResult(schildExport.GetSchoolInfoAsync());
                        WriteLine($"Acamdemic year: {info.CurrentYear}");
                        WriteLine($"Acamdemic year section: {info.CurrentSection}");

                        WriteJson(GetResult(schildExport.GetStudyGroupsAsync(GetResult(schildExport.GetStudentsAsync()), info.CurrentYear.Value, info.CurrentSection.Value)));
                        break;

                    case 8:
                        WriteLine("Get current academic year info...");
                        info = GetResult(schildExport.GetSchoolInfoAsync());
                        WriteLine($"Acamdemic year: {info.CurrentYear}");
                        WriteLine($"Acamdemic year section: {info.CurrentSection}");

                        WriteJson(GetResult(schildExport.GetTuitionsAsync(GetResult(schildExport.GetStudentsAsync()), info.CurrentYear.Value, info.CurrentSection.Value)));
                        break;

                    case 9:
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
