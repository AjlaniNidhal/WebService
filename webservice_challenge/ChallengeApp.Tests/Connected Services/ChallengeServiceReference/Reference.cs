﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChallengeApp.Tests.ChallengeServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChallengeServiceReference.ChallengeServiceSoap")]
    public interface ChallengeServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse XmlToJson(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse> XmlToJsonAsync(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChallengeServiceSoapChannel : ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChallengeServiceSoapClient : System.ServiceModel.ClientBase<ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap>, ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap {
        
        public ChallengeServiceSoapClient() {
        }
        
        public ChallengeServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChallengeServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChallengeServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChallengeServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap.XmlToJson(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest inValue = new ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest();
            inValue.Body = new ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse retVal = ((ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse> ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap.XmlToJsonAsync(ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest inValue = new ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequest();
            inValue.Body = new ChallengeApp.Tests.ChallengeServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((ChallengeApp.Tests.ChallengeServiceReference.ChallengeServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
