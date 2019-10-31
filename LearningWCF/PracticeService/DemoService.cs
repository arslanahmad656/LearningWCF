using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PracticeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DemoService" in both code and config file together.
    public class DemoService : IDemoService
    {
        public string DoWork()
        {
            return "I am doing my work";
        }
    }
}
