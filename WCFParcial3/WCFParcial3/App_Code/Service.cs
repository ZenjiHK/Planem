using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;//ADO.NET es la clase que contiene la tecnología de acceso a datos
using System.Data.SqlClient;//Clase que permite optimizar el acceso a Sql-Server
							//using System.Data.Odbc; //Cuando se quiere conectar a cualquier origen de información donde se debe instalar el cliente en cada equipo (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
							//using System.Data.OleDb; //Cuando se quiere conectar a cualquier origen de información (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
using System.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{

	DataSet ds = new DataSet();

	SqlDataAdapter da;

	string Conexion = ConfigurationManager.ConnectionStrings["ConexionSql"].ToString();

	//public DataSet SP_Departamentos()
//	{

//	//	try
//	//	{
//	//		da = new SqlDataAdapter("SP_Departamentos", Conexion);
//	//		da.SelectCommand.CommandType = CommandType.StoredProcedure;
//	//		da.Fill(ds, "SP_Departamentos");
//	//		return ds;
//	//	}
//	//	catch (Exception)
//	//	{
//	//		//Enviar correo al administrador o al programador del error ocurrido
//	//		return null;
//}
	
}




