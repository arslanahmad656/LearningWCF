using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMultipleServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MultipleContractService" in both code and config file together.
    public class MultipleContractService : IPublicService, IPrivateService
    {
        string IPublicService.DisplayMessage()
        {
            return "This is meant to be a public service";
        }

        string IPrivateService.DisplayMessage()
        {
            return "This is meant to be a private service";
        }
    }
}
