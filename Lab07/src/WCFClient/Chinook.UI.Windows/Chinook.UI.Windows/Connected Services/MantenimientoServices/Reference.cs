﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinook.UI.Windows.MantenimientoServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Chinook.Services.wcf")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Artist", Namespace="http://schemas.datacontract.org/2004/07/Chinook.Entities.Base")]
    [System.SerializableAttribute()]
    public partial class Artist : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArtistIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ArtistId {
            get {
                return this.ArtistIdField;
            }
            set {
                if ((this.ArtistIdField.Equals(value) != true)) {
                    this.ArtistIdField = value;
                    this.RaisePropertyChanged("ArtistId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MantenimientoServices.IMantenimientosServices")]
    public interface IMantenimientosServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetData", ReplyAction="http://tempuri.org/IMantenimientosServices/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetData", ReplyAction="http://tempuri.org/IMantenimientosServices/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMantenimientosServices/GetDataUsingDataContractResponse")]
        Chinook.UI.Windows.MantenimientoServices.CompositeType GetDataUsingDataContract(Chinook.UI.Windows.MantenimientoServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMantenimientosServices/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Chinook.UI.Windows.MantenimientoServices.CompositeType> GetDataUsingDataContractAsync(Chinook.UI.Windows.MantenimientoServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetArtitsByname", ReplyAction="http://tempuri.org/IMantenimientosServices/GetArtitsBynameResponse")]
        Chinook.UI.Windows.MantenimientoServices.Artist[] GetArtitsByname(string artistName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetArtitsByname", ReplyAction="http://tempuri.org/IMantenimientosServices/GetArtitsBynameResponse")]
        System.Threading.Tasks.Task<Chinook.UI.Windows.MantenimientoServices.Artist[]> GetArtitsBynameAsync(string artistName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMantenimientosServicesChannel : Chinook.UI.Windows.MantenimientoServices.IMantenimientosServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MantenimientosServicesClient : System.ServiceModel.ClientBase<Chinook.UI.Windows.MantenimientoServices.IMantenimientosServices>, Chinook.UI.Windows.MantenimientoServices.IMantenimientosServices {
        
        public MantenimientosServicesClient() {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Chinook.UI.Windows.MantenimientoServices.CompositeType GetDataUsingDataContract(Chinook.UI.Windows.MantenimientoServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Chinook.UI.Windows.MantenimientoServices.CompositeType> GetDataUsingDataContractAsync(Chinook.UI.Windows.MantenimientoServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public Chinook.UI.Windows.MantenimientoServices.Artist[] GetArtitsByname(string artistName) {
            return base.Channel.GetArtitsByname(artistName);
        }
        
        public System.Threading.Tasks.Task<Chinook.UI.Windows.MantenimientoServices.Artist[]> GetArtitsBynameAsync(string artistName) {
            return base.Channel.GetArtitsBynameAsync(artistName);
        }
    }
}
