﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsolvencniRejstrik.IsirWs {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://isirpublicws.cca.cz/", ConfigurationName="IsirWs.IsirWsPublicPortType")]
    public interface IsirWsPublicPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isirpublicws.cca.cz/IsirWsPublicPortType/getIsirWsPublicPodnetIdRequest", ReplyAction="http://isirpublicws.cca.cz/IsirWsPublicPortType/getIsirWsPublicPodnetIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdResponse getIsirWsPublicPodnetId(InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://isirpublicws.cca.cz/IsirWsPublicPortType/getIsirWsPublicPodnetIdRequest", ReplyAction="http://isirpublicws.cca.cz/IsirWsPublicPortType/getIsirWsPublicPodnetIdResponse")]
        System.Threading.Tasks.Task<InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdResponse> getIsirWsPublicPodnetIdAsync(InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isirpublicws.cca.cz/types/")]
    public partial class isirWsPublicData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        private System.DateTime datumZalozeniUdalostiField;
        
        private System.DateTime datumZverejneniUdalostiField;
        
        private string dokumentUrlField;
        
        private string spisovaZnackaField;
        
        private string typUdalostiField;
        
        private string popisUdalostiField;
        
        private string oddilField;
        
        private int cisloVOddiluField;
        
        private bool cisloVOddiluFieldSpecified;
        
        private string poznamkaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime datumZalozeniUdalosti {
            get {
                return this.datumZalozeniUdalostiField;
            }
            set {
                this.datumZalozeniUdalostiField = value;
                this.RaisePropertyChanged("datumZalozeniUdalosti");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime datumZverejneniUdalosti {
            get {
                return this.datumZverejneniUdalostiField;
            }
            set {
                this.datumZverejneniUdalostiField = value;
                this.RaisePropertyChanged("datumZverejneniUdalosti");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string dokumentUrl {
            get {
                return this.dokumentUrlField;
            }
            set {
                this.dokumentUrlField = value;
                this.RaisePropertyChanged("dokumentUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string spisovaZnacka {
            get {
                return this.spisovaZnackaField;
            }
            set {
                this.spisovaZnackaField = value;
                this.RaisePropertyChanged("spisovaZnacka");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string typUdalosti {
            get {
                return this.typUdalostiField;
            }
            set {
                this.typUdalostiField = value;
                this.RaisePropertyChanged("typUdalosti");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string popisUdalosti {
            get {
                return this.popisUdalostiField;
            }
            set {
                this.popisUdalostiField = value;
                this.RaisePropertyChanged("popisUdalosti");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string oddil {
            get {
                return this.oddilField;
            }
            set {
                this.oddilField = value;
                this.RaisePropertyChanged("oddil");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int cisloVOddilu {
            get {
                return this.cisloVOddiluField;
            }
            set {
                this.cisloVOddiluField = value;
                this.RaisePropertyChanged("cisloVOddilu");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cisloVOddiluSpecified {
            get {
                return this.cisloVOddiluFieldSpecified;
            }
            set {
                this.cisloVOddiluFieldSpecified = value;
                this.RaisePropertyChanged("cisloVOddiluSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string poznamka {
            get {
                return this.poznamkaField;
            }
            set {
                this.poznamkaField = value;
                this.RaisePropertyChanged("poznamka");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isirpublicws.cca.cz/types/")]
    public partial class isirWsPublicStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private stavType stavField;
        
        private kodChybyType kodChybyField;
        
        private bool kodChybyFieldSpecified;
        
        private string popisChybyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public stavType stav {
            get {
                return this.stavField;
            }
            set {
                this.stavField = value;
                this.RaisePropertyChanged("stav");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public kodChybyType kodChyby {
            get {
                return this.kodChybyField;
            }
            set {
                this.kodChybyField = value;
                this.RaisePropertyChanged("kodChyby");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool kodChybySpecified {
            get {
                return this.kodChybyFieldSpecified;
            }
            set {
                this.kodChybyFieldSpecified = value;
                this.RaisePropertyChanged("kodChybySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string popisChyby {
            get {
                return this.popisChybyField;
            }
            set {
                this.popisChybyField = value;
                this.RaisePropertyChanged("popisChyby");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isirpublicws.cca.cz/types/")]
    public enum stavType {
        
        /// <remarks/>
        OK,
        
        /// <remarks/>
        CHYBA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://isirpublicws.cca.cz/types/")]
    public enum kodChybyType {
        
        /// <remarks/>
        WS1,
        
        /// <remarks/>
        WS2,
        
        /// <remarks/>
        SERVER1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getIsirWsPublicIdDataRequest", WrapperNamespace="http://isirpublicws.cca.cz/types/", IsWrapped=true)]
    public partial class getIsirWsPublicPodnetIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://isirpublicws.cca.cz/types/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idPodnetu;
        
        public getIsirWsPublicPodnetIdRequest() {
        }
        
        public getIsirWsPublicPodnetIdRequest(long idPodnetu) {
            this.idPodnetu = idPodnetu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getIsirWsPublicDataResponse", WrapperNamespace="http://isirpublicws.cca.cz/types/", IsWrapped=true)]
    public partial class getIsirWsPublicPodnetIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://isirpublicws.cca.cz/types/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("data", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public InsolvencniRejstrik.IsirWs.isirWsPublicData[] data;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://isirpublicws.cca.cz/types/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InsolvencniRejstrik.IsirWs.isirWsPublicStatus status;
        
        public getIsirWsPublicPodnetIdResponse() {
        }
        
        public getIsirWsPublicPodnetIdResponse(InsolvencniRejstrik.IsirWs.isirWsPublicData[] data, InsolvencniRejstrik.IsirWs.isirWsPublicStatus status) {
            this.data = data;
            this.status = status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsirWsPublicPortTypeChannel : InsolvencniRejstrik.IsirWs.IsirWsPublicPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsirWsPublicPortTypeClient : System.ServiceModel.ClientBase<InsolvencniRejstrik.IsirWs.IsirWsPublicPortType>, InsolvencniRejstrik.IsirWs.IsirWsPublicPortType {
        
        public IsirWsPublicPortTypeClient() {
        }
        
        public IsirWsPublicPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsirWsPublicPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsirWsPublicPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsirWsPublicPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdResponse InsolvencniRejstrik.IsirWs.IsirWsPublicPortType.getIsirWsPublicPodnetId(InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest request) {
            return base.Channel.getIsirWsPublicPodnetId(request);
        }
        
        public InsolvencniRejstrik.IsirWs.isirWsPublicData[] getIsirWsPublicPodnetId(long idPodnetu, out InsolvencniRejstrik.IsirWs.isirWsPublicStatus status) {
            InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest inValue = new InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest();
            inValue.idPodnetu = idPodnetu;
            InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdResponse retVal = ((InsolvencniRejstrik.IsirWs.IsirWsPublicPortType)(this)).getIsirWsPublicPodnetId(inValue);
            status = retVal.status;
            return retVal.data;
        }
        
        public System.Threading.Tasks.Task<InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdResponse> getIsirWsPublicPodnetIdAsync(InsolvencniRejstrik.IsirWs.getIsirWsPublicPodnetIdRequest request) {
            return base.Channel.getIsirWsPublicPodnetIdAsync(request);
        }
    }
}
