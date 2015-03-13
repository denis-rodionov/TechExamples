using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            int studentCount = int.Parse(ConfigurationManager.AppSettings["StudentCount"]);

            StudentGenerator sGen = new StudentGenerator(connString);
            Console.WriteLine("Generating students...");
            generate(sGen);

            TeacherGenerator tGen = new TeacherGenerator(connString);
            Console.WriteLine("Generating teachers...");
            generate(tGen);

            Console.ReadLine();

        }

        private static void generate(BaseGenerator gen)
        {
            Console.WriteLine("Generated id = " + gen.generate());
        }

    }
}
