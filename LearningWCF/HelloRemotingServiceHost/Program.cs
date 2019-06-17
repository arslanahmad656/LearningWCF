using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace HelloRemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 45012;
            HelloRemotingService.HelloRemotingService service = new HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(port);
#pragma warning disable CS0618 // Type or member is obsolete
            ChannelServices.RegisterChannel(channel);
#pragma warning restore CS0618 // Type or member is obsolete
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine($"Remoting service started at {port}. URI: GetMessage");
            Console.WriteLine($"Press any key to stop...");
            Console.ReadKey();
        }
    }
}
