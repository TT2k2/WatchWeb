﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm.CartService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CartService.CartServiceSoap")]
    public interface CartServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetTable(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Add(string username, string productID, string quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddAsync(string username, string productID, string quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Update(string username, string productID, string quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> UpdateAsync(string username, string productID, string quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Delete(string username, string productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(string username, string productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool CreateOrder(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> CreateOrderAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CartServiceSoapChannel : WebForm.CartService.CartServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CartServiceSoapClient : System.ServiceModel.ClientBase<WebForm.CartService.CartServiceSoap>, WebForm.CartService.CartServiceSoap {
        
        public CartServiceSoapClient() {
        }
        
        public CartServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetTable(string username) {
            return base.Channel.GetTable(username);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync(string username) {
            return base.Channel.GetTableAsync(username);
        }
        
        public bool Add(string username, string productID, string quantity) {
            return base.Channel.Add(username, productID, quantity);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(string username, string productID, string quantity) {
            return base.Channel.AddAsync(username, productID, quantity);
        }
        
        public bool Update(string username, string productID, string quantity) {
            return base.Channel.Update(username, productID, quantity);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(string username, string productID, string quantity) {
            return base.Channel.UpdateAsync(username, productID, quantity);
        }
        
        public bool Delete(string username, string productID) {
            return base.Channel.Delete(username, productID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(string username, string productID) {
            return base.Channel.DeleteAsync(username, productID);
        }
        
        public bool CreateOrder(string username) {
            return base.Channel.CreateOrder(username);
        }
        
        public System.Threading.Tasks.Task<bool> CreateOrderAsync(string username) {
            return base.Channel.CreateOrderAsync(username);
        }
    }
}
