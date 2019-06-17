using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        public string GetGreetingMessage(string name)
        {
            return $"Hello, {name} from remoting service";
        }
    }
}
