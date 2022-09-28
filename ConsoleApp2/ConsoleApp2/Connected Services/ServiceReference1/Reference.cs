﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsoleApp2.ServiceReference1.HelloWorldResponse HelloWorld(ConsoleApp2.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ConsoleApp2.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        float Subtract(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<float> SubtractAsync(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        float Multiply(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<float> MultiplyAsync(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        float Divide(float A, float B);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<float> DivideAsync(float A, float B);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp2.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsoleApp2.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp2.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsoleApp2.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ConsoleApp2.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ConsoleApp2.ServiceReference1.WebService1Soap>, ConsoleApp2.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.HelloWorldResponse ConsoleApp2.ServiceReference1.WebService1Soap.HelloWorld(ConsoleApp2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsoleApp2.ServiceReference1.HelloWorldRequest inValue = new ConsoleApp2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApp2.ServiceReference1.HelloWorldRequestBody();
            ConsoleApp2.ServiceReference1.HelloWorldResponse retVal = ((ConsoleApp2.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.HelloWorldResponse> ConsoleApp2.ServiceReference1.WebService1Soap.HelloWorldAsync(ConsoleApp2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ConsoleApp2.ServiceReference1.HelloWorldRequest inValue = new ConsoleApp2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApp2.ServiceReference1.HelloWorldRequestBody();
            return ((ConsoleApp2.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public float Subtract(float A, float B) {
            return base.Channel.Subtract(A, B);
        }
        
        public System.Threading.Tasks.Task<float> SubtractAsync(float A, float B) {
            return base.Channel.SubtractAsync(A, B);
        }
        
        public float Multiply(float A, float B) {
            return base.Channel.Multiply(A, B);
        }
        
        public System.Threading.Tasks.Task<float> MultiplyAsync(float A, float B) {
            return base.Channel.MultiplyAsync(A, B);
        }
        
        public float Divide(float A, float B) {
            return base.Channel.Divide(A, B);
        }
        
        public System.Threading.Tasks.Task<float> DivideAsync(float A, float B) {
            return base.Channel.DivideAsync(A, B);
        }
    }
}
