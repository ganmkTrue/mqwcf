﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageDealingClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPublicMessageQueue")]
    public interface IPublicMessageQueue {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublicMessageQueue/SendMessage")]
        void SendMessage(string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublicMessageQueue/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublicMessageQueueChannel : MessageDealingClient.ServiceReference1.IPublicMessageQueue, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublicMessageQueueClient : System.ServiceModel.ClientBase<MessageDealingClient.ServiceReference1.IPublicMessageQueue>, MessageDealingClient.ServiceReference1.IPublicMessageQueue {
        
        public PublicMessageQueueClient() {
        }
        
        public PublicMessageQueueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PublicMessageQueueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicMessageQueueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicMessageQueueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendMessage(string msg) {
            base.Channel.SendMessage(msg);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string msg) {
            return base.Channel.SendMessageAsync(msg);
        }
    }
}
