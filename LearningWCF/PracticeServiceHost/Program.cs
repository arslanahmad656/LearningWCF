using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PracticeService;

namespace PracticeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(DemoService)))
            {
                host.Open();
                Console.WriteLine($"Host listening at {string.Join(Environment.NewLine, host.BaseAddresses.Select(a => a.AbsoluteUri))}");
                Console.WriteLine($"Press any key to stop...");
                Console.ReadKey(true);
            }
        }
    }
}
