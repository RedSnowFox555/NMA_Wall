﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMA_Wall.ASMXService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ASMXService.NMASoap")]
    public interface NMASoap {
        
        // CODEGEN: Generating message contract since element name GetCommentsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetComments", ReplyAction="*")]
        NMA_Wall.ASMXService.GetCommentsResponse GetComments(NMA_Wall.ASMXService.GetCommentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetComments", ReplyAction="*")]
        System.Threading.Tasks.Task<NMA_Wall.ASMXService.GetCommentsResponse> GetCommentsAsync(NMA_Wall.ASMXService.GetCommentsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCommentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetComments", Namespace="http://tempuri.org/", Order=0)]
        public NMA_Wall.ASMXService.GetCommentsRequestBody Body;
        
        public GetCommentsRequest() {
        }
        
        public GetCommentsRequest(NMA_Wall.ASMXService.GetCommentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCommentsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double lat;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double lon;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double dist;
        
        public GetCommentsRequestBody() {
        }
        
        public GetCommentsRequestBody(double lat, double lon, double dist) {
            this.lat = lat;
            this.lon = lon;
            this.dist = dist;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCommentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCommentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public NMA_Wall.ASMXService.GetCommentsResponseBody Body;
        
        public GetCommentsResponse() {
        }
        
        public GetCommentsResponse(NMA_Wall.ASMXService.GetCommentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCommentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCommentsResult;
        
        public GetCommentsResponseBody() {
        }
        
        public GetCommentsResponseBody(string GetCommentsResult) {
            this.GetCommentsResult = GetCommentsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NMASoapChannel : NMA_Wall.ASMXService.NMASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NMASoapClient : System.ServiceModel.ClientBase<NMA_Wall.ASMXService.NMASoap>, NMA_Wall.ASMXService.NMASoap {
        
        public NMASoapClient() {
        }
        
        public NMASoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NMASoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NMASoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NMASoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NMA_Wall.ASMXService.GetCommentsResponse NMA_Wall.ASMXService.NMASoap.GetComments(NMA_Wall.ASMXService.GetCommentsRequest request) {
            return base.Channel.GetComments(request);
        }
        
        public string GetComments(double lat, double lon, double dist) {
            NMA_Wall.ASMXService.GetCommentsRequest inValue = new NMA_Wall.ASMXService.GetCommentsRequest();
            inValue.Body = new NMA_Wall.ASMXService.GetCommentsRequestBody();
            inValue.Body.lat = lat;
            inValue.Body.lon = lon;
            inValue.Body.dist = dist;
            NMA_Wall.ASMXService.GetCommentsResponse retVal = ((NMA_Wall.ASMXService.NMASoap)(this)).GetComments(inValue);
            return retVal.Body.GetCommentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NMA_Wall.ASMXService.GetCommentsResponse> NMA_Wall.ASMXService.NMASoap.GetCommentsAsync(NMA_Wall.ASMXService.GetCommentsRequest request) {
            return base.Channel.GetCommentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<NMA_Wall.ASMXService.GetCommentsResponse> GetCommentsAsync(double lat, double lon, double dist) {
            NMA_Wall.ASMXService.GetCommentsRequest inValue = new NMA_Wall.ASMXService.GetCommentsRequest();
            inValue.Body = new NMA_Wall.ASMXService.GetCommentsRequestBody();
            inValue.Body.lat = lat;
            inValue.Body.lon = lon;
            inValue.Body.dist = dist;
            return ((NMA_Wall.ASMXService.NMASoap)(this)).GetCommentsAsync(inValue);
        }
    }
}