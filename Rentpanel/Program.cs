using Rentpanel.Forms;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Rentpanel.Wrappers;

namespace Rentpanel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string jsonDataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data","UserLogin.json");
            string jsonDataStr=File.ReadAllText(jsonDataFilePath);
            List<UserLogin> people = JsonConvert.DeserializeObject<List<UserLogin>>(jsonDataStr);
            Console.WriteLine(jsonDataStr);



            string file = @"C:\Users\DiaKo System\source\repos\Rentpanel\Rentpanel\Files\info.txt";

            //bareye kole file hast
            Console.WriteLine("Reading File using File.ReadAllText() ");
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);

                Console.WriteLine(str);

            }
            Console.WriteLine();


            //baraye inke masalan khat haro joda knim az tooye file
            Console.WriteLine("Reading File using File.ReadAllLines()");
            if (File.Exists(file))
            {

                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                    Console.WriteLine(ln);
            }
            Console.WriteLine();



            Console.WriteLine("Reading File using File.StreamReader()");
            if (File.Exists(file))
            {
                StreamReader Textfile = new StreamReader(file);
                string line;
                while ((line = Textfile.ReadLine()) != null)
                { 
                    Console.WriteLine(line); 
                }
                Textfile.Close();

            }

            Console.WriteLine();

            //hamishe in path baraye ma ejbari ast
            Console.WriteLine("Reading file by Dynamic Path ");
            String filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "info.txt");
                if (File.Exists(filePath))
            {
                string str = File.ReadAllText(filePath);
                Console.WriteLine(str);


            }
                Console.WriteLine() ;
            if (File.Exists(filePath))
            {
                File.AppendAllText(path: filePath, contents: "hello");
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new newForm1());


        }
    }
}