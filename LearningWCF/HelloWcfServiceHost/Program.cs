using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWcfServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloWcfService.HelloWcfService)))
            {
                host.Open();
                Console.WriteLine("WCF service started");
                Console.ReadKey();
            }
        }
    }
}
