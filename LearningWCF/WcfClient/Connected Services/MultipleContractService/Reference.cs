﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.MultipleContractService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MultipleContractService.IPublicService")]
    public interface IPublicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublicService/DisplayMessagePublic", ReplyAction="http://tempuri.org/IPublicService/DisplayMessagePublicResponse")]
        string DisplayMessagePublic();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublicService/DisplayMessagePublic", ReplyAction="http://tempuri.org/IPublicService/DisplayMessagePublicResponse")]
        System.Threading.Tasks.Task<string> DisplayMessagePublicAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublicServiceChannel : WcfClient.MultipleContractService.IPublicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublicServiceClient : System.ServiceModel.ClientBase<WcfClient.MultipleContractService.IPublicService>, WcfClient.MultipleContractService.IPublicService {
        
        public PublicServiceClient() {
        }
        
        public PublicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PublicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DisplayMessagePublic() {
            return base.Channel.DisplayMessagePublic();
        }
        
        public System.Threading.Tasks.Task<string> DisplayMessagePublicAsync() {
            return base.Channel.DisplayMessagePublicAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MultipleContractService.IPrivateService")]
    public interface IPrivateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrivateService/DisplayMessagePrivate", ReplyAction="http://tempuri.org/IPrivateService/DisplayMessagePrivateResponse")]
        string DisplayMessagePrivate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrivateService/DisplayMessagePrivate", ReplyAction="http://tempuri.org/IPrivateService/DisplayMessagePrivateResponse")]
        System.Threading.Tasks.Task<string> DisplayMessagePrivateAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrivateServiceChannel : WcfClient.MultipleContractService.IPrivateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrivateServiceClient : System.ServiceModel.ClientBase<WcfClient.MultipleContractService.IPrivateService>, WcfClient.MultipleContractService.IPrivateService {
        
        public PrivateServiceClient() {
        }
        
        public PrivateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrivateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrivateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrivateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DisplayMessagePrivate() {
            return base.Channel.DisplayMessagePrivate();
        }
        
        public System.Threading.Tasks.Task<string> DisplayMessagePrivateAsync() {
            return base.Channel.DisplayMessagePrivateAsync();
        }
    }
}
