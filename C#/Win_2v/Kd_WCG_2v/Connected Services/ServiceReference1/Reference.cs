//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kd_WCG_2v.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindByName", ReplyAction="http://tempuri.org/IService1/FindByNameResponse")]
        string FindByName(string S);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindByName", ReplyAction="http://tempuri.org/IService1/FindByNameResponse")]
        System.Threading.Tasks.Task<string> FindByNameAsync(string S);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vardi", ReplyAction="http://tempuri.org/IService1/VardiResponse")]
        string[] Vardi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vardi", ReplyAction="http://tempuri.org/IService1/VardiResponse")]
        System.Threading.Tasks.Task<string[]> VardiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vardusk", ReplyAction="http://tempuri.org/IService1/VarduskResponse")]
        int Vardusk();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Vardusk", ReplyAction="http://tempuri.org/IService1/VarduskResponse")]
        System.Threading.Tasks.Task<int> VarduskAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyName", ReplyAction="http://tempuri.org/IService1/SortedbyNameResponse")]
        string SortedbyName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyName", ReplyAction="http://tempuri.org/IService1/SortedbyNameResponse")]
        System.Threading.Tasks.Task<string> SortedbyNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyRun100m", ReplyAction="http://tempuri.org/IService1/SortedbyRun100mResponse")]
        string SortedbyRun100m();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyRun100m", ReplyAction="http://tempuri.org/IService1/SortedbyRun100mResponse")]
        System.Threading.Tasks.Task<string> SortedbyRun100mAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyLeksana", ReplyAction="http://tempuri.org/IService1/SortedbyLeksanaResponse")]
        string SortedbyLeksana();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyLeksana", ReplyAction="http://tempuri.org/IService1/SortedbyLeksanaResponse")]
        System.Threading.Tasks.Task<string> SortedbyLeksanaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyHeight", ReplyAction="http://tempuri.org/IService1/SortedbyHeightResponse")]
        string SortedbyHeight();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyHeight", ReplyAction="http://tempuri.org/IService1/SortedbyHeightResponse")]
        System.Threading.Tasks.Task<string> SortedbyHeightAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyNameBR", ReplyAction="http://tempuri.org/IService1/SortedbyNameBRResponse")]
        string SortedbyNameBR();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyNameBR", ReplyAction="http://tempuri.org/IService1/SortedbyNameBRResponse")]
        System.Threading.Tasks.Task<string> SortedbyNameBRAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyRun100mBR", ReplyAction="http://tempuri.org/IService1/SortedbyRun100mBRResponse")]
        string SortedbyRun100mBR();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyRun100mBR", ReplyAction="http://tempuri.org/IService1/SortedbyRun100mBRResponse")]
        System.Threading.Tasks.Task<string> SortedbyRun100mBRAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyLeksanaBR", ReplyAction="http://tempuri.org/IService1/SortedbyLeksanaBRResponse")]
        string SortedbyLeksanaBR();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyLeksanaBR", ReplyAction="http://tempuri.org/IService1/SortedbyLeksanaBRResponse")]
        System.Threading.Tasks.Task<string> SortedbyLeksanaBRAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyHeightBR", ReplyAction="http://tempuri.org/IService1/SortedbyHeightBRResponse")]
        string SortedbyHeightBR();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SortedbyHeightBR", ReplyAction="http://tempuri.org/IService1/SortedbyHeightBRResponse")]
        System.Threading.Tasks.Task<string> SortedbyHeightBRAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Kd_WCG_2v.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Kd_WCG_2v.ServiceReference1.IService1>, Kd_WCG_2v.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string FindByName(string S) {
            return base.Channel.FindByName(S);
        }
        
        public System.Threading.Tasks.Task<string> FindByNameAsync(string S) {
            return base.Channel.FindByNameAsync(S);
        }
        
        public string[] Vardi() {
            return base.Channel.Vardi();
        }
        
        public System.Threading.Tasks.Task<string[]> VardiAsync() {
            return base.Channel.VardiAsync();
        }
        
        public int Vardusk() {
            return base.Channel.Vardusk();
        }
        
        public System.Threading.Tasks.Task<int> VarduskAsync() {
            return base.Channel.VarduskAsync();
        }
        
        public string SortedbyName() {
            return base.Channel.SortedbyName();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyNameAsync() {
            return base.Channel.SortedbyNameAsync();
        }
        
        public string SortedbyRun100m() {
            return base.Channel.SortedbyRun100m();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyRun100mAsync() {
            return base.Channel.SortedbyRun100mAsync();
        }
        
        public string SortedbyLeksana() {
            return base.Channel.SortedbyLeksana();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyLeksanaAsync() {
            return base.Channel.SortedbyLeksanaAsync();
        }
        
        public string SortedbyHeight() {
            return base.Channel.SortedbyHeight();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyHeightAsync() {
            return base.Channel.SortedbyHeightAsync();
        }
        
        public string SortedbyNameBR() {
            return base.Channel.SortedbyNameBR();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyNameBRAsync() {
            return base.Channel.SortedbyNameBRAsync();
        }
        
        public string SortedbyRun100mBR() {
            return base.Channel.SortedbyRun100mBR();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyRun100mBRAsync() {
            return base.Channel.SortedbyRun100mBRAsync();
        }
        
        public string SortedbyLeksanaBR() {
            return base.Channel.SortedbyLeksanaBR();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyLeksanaBRAsync() {
            return base.Channel.SortedbyLeksanaBRAsync();
        }
        
        public string SortedbyHeightBR() {
            return base.Channel.SortedbyHeightBR();
        }
        
        public System.Threading.Tasks.Task<string> SortedbyHeightBRAsync() {
            return base.Channel.SortedbyHeightBRAsync();
        }
    }
}
