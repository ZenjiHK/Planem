using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: agregue aquí sus operaciones de servicio
	[OperationContract]
	DataSet pa_NuevoEmpleado(string nombres,string apellidos,DateTime fecha_nacimiento,string correo_electronico,string dui,string nit,string telefono,string direccion,int id_departamento,int id_sexo);
	[OperationContract]
	DataSet pa_sexo();
	[OperationContract]
	DataSet pa_Departamento(); 
		[OperationContract]
	DataSet pa_SubDepartamento(int id_departamento);
	[OperationContract]
	DataSet pa_Turno_Horario();
	[OperationContract]
	DataSet pa_Plaza();
	[OperationContract]
	DataSet pa_Mes();
	[OperationContract]
	DataSet pa_Contrato(int id_empleado,int id_plaza,int id_turno,int horas_semana,double salario_base);
	[OperationContract]
	DataSet pa_boleta_pago(int pa_dias, double pa_horas, int pa_empleado, int pa_mes);
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
