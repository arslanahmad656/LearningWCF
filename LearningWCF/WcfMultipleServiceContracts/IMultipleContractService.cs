using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMultipleServiceContracts
{
    [ServiceContract]
    public interface IPublicService
    {
        [OperationContract]
        string DisplayMessage();
    }

    public interface IPrivateService
    {
        [OperationContract]
        string DisplayMessage();
    }
}
