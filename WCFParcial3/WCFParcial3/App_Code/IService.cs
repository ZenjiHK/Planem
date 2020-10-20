using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	//[OperationContract]
	//DataSet SP_Departamentos();

	//[OperationContract]
	//DataSet BusquedaEmpleado(int Id_Empleado);


	//[OperationContract]
	//DataSet InsertarEmpleado(string Nombre, string Direccion, string Telefono, string DUI, Double Salario, int Id_Departamento);


	//[OperationContract]
	//DataSet ModificarEmpleados(int Id_Empleado, string Nombre, string Direccion, string Telefono, string DUI, double Salario, int Id_Departamento, bool Estado);
}


