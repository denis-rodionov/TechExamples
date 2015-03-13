using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfService;
using System.ServiceModel;

namespace WcfSecurityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service = new Service1();
            
            ServiceHost host = new ServiceHost(service);
            
            
            host.Open();
            Console.WriteLine("Started!");
            Console.ReadLine();
            host.Close();
        }
    }
}
