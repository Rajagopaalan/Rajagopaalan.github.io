﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assign4tryit.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.xmlserviceSoap")]
    public interface xmlserviceSoap {
        
        // CODEGEN: Generating message contract since element name xmlpath from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/xPathfind", ReplyAction="*")]
        assign4tryit.ServiceReference1.xPathfindResponse xPathfind(assign4tryit.ServiceReference1.xPathfindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/xPathfind", ReplyAction="*")]
        System.Threading.Tasks.Task<assign4tryit.ServiceReference1.xPathfindResponse> xPathfindAsync(assign4tryit.ServiceReference1.xPathfindRequest request);
        
        // CODEGEN: Generating message contract since element name xmlpath from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/verification", ReplyAction="*")]
        assign4tryit.ServiceReference1.verificationResponse verification(assign4tryit.ServiceReference1.verificationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/verification", ReplyAction="*")]
        System.Threading.Tasks.Task<assign4tryit.ServiceReference1.verificationResponse> verificationAsync(assign4tryit.ServiceReference1.verificationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class xPathfindRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="xPathfind", Namespace="http://tempuri.org/", Order=0)]
        public assign4tryit.ServiceReference1.xPathfindRequestBody Body;
        
        public xPathfindRequest() {
        }
        
        public xPathfindRequest(assign4tryit.ServiceReference1.xPathfindRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class xPathfindRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlpath;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string xPathexpr;
        
        public xPathfindRequestBody() {
        }
        
        public xPathfindRequestBody(string xmlpath, string xPathexpr) {
            this.xmlpath = xmlpath;
            this.xPathexpr = xPathexpr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class xPathfindResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="xPathfindResponse", Namespace="http://tempuri.org/", Order=0)]
        public assign4tryit.ServiceReference1.xPathfindResponseBody Body;
        
        public xPathfindResponse() {
        }
        
        public xPathfindResponse(assign4tryit.ServiceReference1.xPathfindResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class xPathfindResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xPathfindResult;
        
        public xPathfindResponseBody() {
        }
        
        public xPathfindResponseBody(string xPathfindResult) {
            this.xPathfindResult = xPathfindResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class verificationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="verification", Namespace="http://tempuri.org/", Order=0)]
        public assign4tryit.ServiceReference1.verificationRequestBody Body;
        
        public verificationRequest() {
        }
        
        public verificationRequest(assign4tryit.ServiceReference1.verificationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class verificationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlpath;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string xsdpath;
        
        public verificationRequestBody() {
        }
        
        public verificationRequestBody(string xmlpath, string xsdpath) {
            this.xmlpath = xmlpath;
            this.xsdpath = xsdpath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class verificationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="verificationResponse", Namespace="http://tempuri.org/", Order=0)]
        public assign4tryit.ServiceReference1.verificationResponseBody Body;
        
        public verificationResponse() {
        }
        
        public verificationResponse(assign4tryit.ServiceReference1.verificationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class verificationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string verificationResult;
        
        public verificationResponseBody() {
        }
        
        public verificationResponseBody(string verificationResult) {
            this.verificationResult = verificationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface xmlserviceSoapChannel : assign4tryit.ServiceReference1.xmlserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class xmlserviceSoapClient : System.ServiceModel.ClientBase<assign4tryit.ServiceReference1.xmlserviceSoap>, assign4tryit.ServiceReference1.xmlserviceSoap {
        
        public xmlserviceSoapClient() {
        }
        
        public xmlserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public xmlserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xmlserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xmlserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        assign4tryit.ServiceReference1.xPathfindResponse assign4tryit.ServiceReference1.xmlserviceSoap.xPathfind(assign4tryit.ServiceReference1.xPathfindRequest request) {
            return base.Channel.xPathfind(request);
        }
        
        public string xPathfind(string xmlpath, string xPathexpr) {
            assign4tryit.ServiceReference1.xPathfindRequest inValue = new assign4tryit.ServiceReference1.xPathfindRequest();
            inValue.Body = new assign4tryit.ServiceReference1.xPathfindRequestBody();
            inValue.Body.xmlpath = xmlpath;
            inValue.Body.xPathexpr = xPathexpr;
            assign4tryit.ServiceReference1.xPathfindResponse retVal = ((assign4tryit.ServiceReference1.xmlserviceSoap)(this)).xPathfind(inValue);
            return retVal.Body.xPathfindResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<assign4tryit.ServiceReference1.xPathfindResponse> assign4tryit.ServiceReference1.xmlserviceSoap.xPathfindAsync(assign4tryit.ServiceReference1.xPathfindRequest request) {
            return base.Channel.xPathfindAsync(request);
        }
        
        public System.Threading.Tasks.Task<assign4tryit.ServiceReference1.xPathfindResponse> xPathfindAsync(string xmlpath, string xPathexpr) {
            assign4tryit.ServiceReference1.xPathfindRequest inValue = new assign4tryit.ServiceReference1.xPathfindRequest();
            inValue.Body = new assign4tryit.ServiceReference1.xPathfindRequestBody();
            inValue.Body.xmlpath = xmlpath;
            inValue.Body.xPathexpr = xPathexpr;
            return ((assign4tryit.ServiceReference1.xmlserviceSoap)(this)).xPathfindAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        assign4tryit.ServiceReference1.verificationResponse assign4tryit.ServiceReference1.xmlserviceSoap.verification(assign4tryit.ServiceReference1.verificationRequest request) {
            return base.Channel.verification(request);
        }
        
        public string verification(string xmlpath, string xsdpath) {
            assign4tryit.ServiceReference1.verificationRequest inValue = new assign4tryit.ServiceReference1.verificationRequest();
            inValue.Body = new assign4tryit.ServiceReference1.verificationRequestBody();
            inValue.Body.xmlpath = xmlpath;
            inValue.Body.xsdpath = xsdpath;
            assign4tryit.ServiceReference1.verificationResponse retVal = ((assign4tryit.ServiceReference1.xmlserviceSoap)(this)).verification(inValue);
            return retVal.Body.verificationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<assign4tryit.ServiceReference1.verificationResponse> assign4tryit.ServiceReference1.xmlserviceSoap.verificationAsync(assign4tryit.ServiceReference1.verificationRequest request) {
            return base.Channel.verificationAsync(request);
        }
        
        public System.Threading.Tasks.Task<assign4tryit.ServiceReference1.verificationResponse> verificationAsync(string xmlpath, string xsdpath) {
            assign4tryit.ServiceReference1.verificationRequest inValue = new assign4tryit.ServiceReference1.verificationRequest();
            inValue.Body = new assign4tryit.ServiceReference1.verificationRequestBody();
            inValue.Body.xmlpath = xmlpath;
            inValue.Body.xsdpath = xsdpath;
            return ((assign4tryit.ServiceReference1.xmlserviceSoap)(this)).verificationAsync(inValue);
        }
    }
}