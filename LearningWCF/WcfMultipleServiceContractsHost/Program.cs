using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfMultipleServiceContracts;

namespace WcfMultipleServiceContractsHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MultipleContractService)))
            {
                host.Open();
                Console.WriteLine($"Host started");
                Console.ReadKey();
            }
        }
    }
}
