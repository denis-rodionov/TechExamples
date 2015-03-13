using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientWCF.ServiceReference1;
using System.IO;


namespace ClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Service1Client client = new Service1Client();
                Console.WriteLine(client.GetData(123));
                Console.ReadLine();
                client.Close();
            }
            catch (Exception ex)
            {
                using (Stream stream = File.OpenWrite("exception.txt"))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(ex.GetType().ToString());
                    writer.WriteLine(ex.Message);
                    writer.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
