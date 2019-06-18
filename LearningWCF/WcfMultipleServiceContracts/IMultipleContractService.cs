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
        [OperationContract(Name = "DisplayMessagePublic")]
        string DisplayMessage();
    }

    [ServiceContract]
    public interface IPrivateService
    {
        [OperationContract(Name = "DisplayMessagePrivate")]
        string DisplayMessage();
    }
}
