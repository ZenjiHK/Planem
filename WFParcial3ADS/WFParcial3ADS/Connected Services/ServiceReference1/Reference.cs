﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFParcial3ADS.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        WFParcial3ADS.ServiceReference1.CompositeType GetDataUsingDataContract(WFParcial3ADS.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WFParcial3ADS.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WFParcial3ADS.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_NuevoEmpleado", ReplyAction="http://tempuri.org/IService/pa_NuevoEmpleadoResponse")]
        System.Data.DataSet pa_NuevoEmpleado(string nombres, string apellidos, System.DateTime fecha_nacimiento, string correo_electronico, string dui, string nit, string telefono, string direccion, int id_departamento, int id_sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_NuevoEmpleado", ReplyAction="http://tempuri.org/IService/pa_NuevoEmpleadoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_NuevoEmpleadoAsync(string nombres, string apellidos, System.DateTime fecha_nacimiento, string correo_electronico, string dui, string nit, string telefono, string direccion, int id_departamento, int id_sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_sexo", ReplyAction="http://tempuri.org/IService/pa_sexoResponse")]
        System.Data.DataSet pa_sexo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_sexo", ReplyAction="http://tempuri.org/IService/pa_sexoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_sexoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Departamento", ReplyAction="http://tempuri.org/IService/pa_DepartamentoResponse")]
        System.Data.DataSet pa_Departamento();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Departamento", ReplyAction="http://tempuri.org/IService/pa_DepartamentoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_DepartamentoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_SubDepartamento", ReplyAction="http://tempuri.org/IService/pa_SubDepartamentoResponse")]
        System.Data.DataSet pa_SubDepartamento(int id_departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_SubDepartamento", ReplyAction="http://tempuri.org/IService/pa_SubDepartamentoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_SubDepartamentoAsync(int id_departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Turno_Horario", ReplyAction="http://tempuri.org/IService/pa_Turno_HorarioResponse")]
        System.Data.DataSet pa_Turno_Horario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Turno_Horario", ReplyAction="http://tempuri.org/IService/pa_Turno_HorarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_Turno_HorarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Plaza", ReplyAction="http://tempuri.org/IService/pa_PlazaResponse")]
        System.Data.DataSet pa_Plaza();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Plaza", ReplyAction="http://tempuri.org/IService/pa_PlazaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_PlazaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Mes", ReplyAction="http://tempuri.org/IService/pa_MesResponse")]
        System.Data.DataSet pa_Mes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Mes", ReplyAction="http://tempuri.org/IService/pa_MesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_MesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Contrato", ReplyAction="http://tempuri.org/IService/pa_ContratoResponse")]
        System.Data.DataSet pa_Contrato(int id_empleado, int id_plaza, int id_turno, int horas_semana, double salario_base);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_Contrato", ReplyAction="http://tempuri.org/IService/pa_ContratoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_ContratoAsync(int id_empleado, int id_plaza, int id_turno, int horas_semana, double salario_base);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_boleta_pago", ReplyAction="http://tempuri.org/IService/pa_boleta_pagoResponse")]
        System.Data.DataSet pa_boleta_pago(int pa_dias, double pa_horas, int pa_empleado, int pa_mes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_boleta_pago", ReplyAction="http://tempuri.org/IService/pa_boleta_pagoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_boleta_pagoAsync(int pa_dias, double pa_horas, int pa_empleado, int pa_mes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_EmpSinContrato", ReplyAction="http://tempuri.org/IService/pa_EmpSinContratoResponse")]
        System.Data.DataSet pa_EmpSinContrato();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_EmpSinContrato", ReplyAction="http://tempuri.org/IService/pa_EmpSinContratoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_EmpSinContratoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_EmpleadosList", ReplyAction="http://tempuri.org/IService/pa_EmpleadosListResponse")]
        System.Data.DataSet pa_EmpleadosList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/pa_EmpleadosList", ReplyAction="http://tempuri.org/IService/pa_EmpleadosListResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> pa_EmpleadosListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WFParcial3ADS.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WFParcial3ADS.ServiceReference1.IService>, WFParcial3ADS.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WFParcial3ADS.ServiceReference1.CompositeType GetDataUsingDataContract(WFParcial3ADS.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WFParcial3ADS.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WFParcial3ADS.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Data.DataSet pa_NuevoEmpleado(string nombres, string apellidos, System.DateTime fecha_nacimiento, string correo_electronico, string dui, string nit, string telefono, string direccion, int id_departamento, int id_sexo) {
            return base.Channel.pa_NuevoEmpleado(nombres, apellidos, fecha_nacimiento, correo_electronico, dui, nit, telefono, direccion, id_departamento, id_sexo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_NuevoEmpleadoAsync(string nombres, string apellidos, System.DateTime fecha_nacimiento, string correo_electronico, string dui, string nit, string telefono, string direccion, int id_departamento, int id_sexo) {
            return base.Channel.pa_NuevoEmpleadoAsync(nombres, apellidos, fecha_nacimiento, correo_electronico, dui, nit, telefono, direccion, id_departamento, id_sexo);
        }
        
        public System.Data.DataSet pa_sexo() {
            return base.Channel.pa_sexo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_sexoAsync() {
            return base.Channel.pa_sexoAsync();
        }
        
        public System.Data.DataSet pa_Departamento() {
            return base.Channel.pa_Departamento();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_DepartamentoAsync() {
            return base.Channel.pa_DepartamentoAsync();
        }
        
        public System.Data.DataSet pa_SubDepartamento(int id_departamento) {
            return base.Channel.pa_SubDepartamento(id_departamento);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_SubDepartamentoAsync(int id_departamento) {
            return base.Channel.pa_SubDepartamentoAsync(id_departamento);
        }
        
        public System.Data.DataSet pa_Turno_Horario() {
            return base.Channel.pa_Turno_Horario();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_Turno_HorarioAsync() {
            return base.Channel.pa_Turno_HorarioAsync();
        }
        
        public System.Data.DataSet pa_Plaza() {
            return base.Channel.pa_Plaza();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_PlazaAsync() {
            return base.Channel.pa_PlazaAsync();
        }
        
        public System.Data.DataSet pa_Mes() {
            return base.Channel.pa_Mes();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_MesAsync() {
            return base.Channel.pa_MesAsync();
        }
        
        public System.Data.DataSet pa_Contrato(int id_empleado, int id_plaza, int id_turno, int horas_semana, double salario_base) {
            return base.Channel.pa_Contrato(id_empleado, id_plaza, id_turno, horas_semana, salario_base);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_ContratoAsync(int id_empleado, int id_plaza, int id_turno, int horas_semana, double salario_base) {
            return base.Channel.pa_ContratoAsync(id_empleado, id_plaza, id_turno, horas_semana, salario_base);
        }
        
        public System.Data.DataSet pa_boleta_pago(int pa_dias, double pa_horas, int pa_empleado, int pa_mes) {
            return base.Channel.pa_boleta_pago(pa_dias, pa_horas, pa_empleado, pa_mes);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_boleta_pagoAsync(int pa_dias, double pa_horas, int pa_empleado, int pa_mes) {
            return base.Channel.pa_boleta_pagoAsync(pa_dias, pa_horas, pa_empleado, pa_mes);
        }
        
        public System.Data.DataSet pa_EmpSinContrato() {
            return base.Channel.pa_EmpSinContrato();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_EmpSinContratoAsync() {
            return base.Channel.pa_EmpSinContratoAsync();
        }
        
        public System.Data.DataSet pa_EmpleadosList() {
            return base.Channel.pa_EmpleadosList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> pa_EmpleadosListAsync() {
            return base.Channel.pa_EmpleadosListAsync();
        }
    }
}
