using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new DemoServiceProxy.DemoServiceClient("BasicHttpBinding_IDemoService");
            var tcpClient = new DemoServiceProxy.DemoServiceClient("NetTcpBinding_IDemoService");
            var work1 = httpClient.DoWork();
            var work2 = tcpClient.DoWork();
            Console.WriteLine($"Work is '{work1}'; work 2 is '{work2}'");
        }
    }
}
