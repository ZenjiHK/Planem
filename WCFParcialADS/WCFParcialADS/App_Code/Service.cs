using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;//ADO.NET es la clase que contiene la tecnología de acceso a datos
using System.Data.SqlClient;//Clase que permite optimizar el acceso a Sql-Server
using System.Data.Odbc; //Cuando se quiere conectar a cualquier origen de información donde se debe instalar el cliente en cada equipo (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
using System.Data.OleDb; //Cuando se quiere conectar a cualquier origen de información (Oracle, Sybase, DB2, MySql, Sql-Server, etc.)
using System.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
	DataSet ds = new DataSet();
	SqlDataAdapter da;
	string Conexion = ConfigurationManager.ConnectionStrings["ConexionSql"].ToString();
	public DataSet pa_NuevoEmpleado(string nombres, string apellidos, DateTime fecha_nacimiento, string correo_electronico, string dui, string nit, string telefono, string direccion, int id_departamento, int id_sexo)
	{
		try
		{
			da = new SqlDataAdapter("pa_NuevoEmpleado", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@nombres", nombres);
			da.SelectCommand.Parameters.AddWithValue("@apellidos", apellidos);
			da.SelectCommand.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
			da.SelectCommand.Parameters.AddWithValue("@correo_electronico", correo_electronico);
			da.SelectCommand.Parameters.AddWithValue("@dui", dui);
			da.SelectCommand.Parameters.AddWithValue("@nit", nit);
			da.SelectCommand.Parameters.AddWithValue("@telefono", telefono);
			da.SelectCommand.Parameters.AddWithValue("@direccion", direccion);
			da.SelectCommand.Parameters.AddWithValue("@id_departamento", id_departamento);
			da.SelectCommand.Parameters.AddWithValue("@id_sexo", id_sexo);
			da.Fill(ds, "pa_NuevoEmpleado");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_sexo()
	{
		try
		{
			da = new SqlDataAdapter("pa_sexo", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_sexo");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_Departamento()
	{
		try
		{
			da = new SqlDataAdapter("pa_Departamento", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_Departamento");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_SubDepartamento(int id_departamento)
	{
		try
		{
			da = new SqlDataAdapter("pa_SubDepartamento", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_SubDepartamento");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_Turno_Horario()
	{
		try
		{
			da = new SqlDataAdapter("pa_Turno_Horario", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_Turno_Horario");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_Plaza()
	{
		try
		{
			da = new SqlDataAdapter("pa_Plaza", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_Plaza");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_Mes()
	{
		try
		{
			da = new SqlDataAdapter("pa_Mes", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.Fill(ds, "pa_Mes");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}

	}
	public DataSet pa_Contrato(int id_empleado, int id_plaza, int id_turno, int horas_semana, double salario_base)
	{
		try
		{
			da = new SqlDataAdapter("pa_Contrato", Conexion);
			da.SelectCommand.CommandType = CommandType.StoredProcedure;
			da.SelectCommand.Parameters.AddWithValue("@id_empleado", id_empleado);
			da.SelectCommand.Parameters.AddWithValue("@id_plaza", id_plaza);
			da.SelectCommand.Parameters.AddWithValue("@id_turno", id_turno);
			da.SelectCommand.Parameters.AddWithValue("@horas_semana", horas_semana);
			da.SelectCommand.Parameters.AddWithValue("@salario_base", salario_base);
			da.Fill(ds, "pa_Contrato");
			return ds;
		}
		catch (Exception)
		{//Enviar correo al administrador o al programador del error ocurrido
			return null;
		}
	}
		public DataSet pa_boleta_pago(int pa_dias, double pa_horas, int pa_empleado, int pa_mes)
	{
			try
			{
				da = new SqlDataAdapter("pa_boleta_pago", Conexion);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@pa_dias", pa_dias);
				da.SelectCommand.Parameters.AddWithValue("@pa_horas", pa_horas);
				da.SelectCommand.Parameters.AddWithValue("@pa_empleado", pa_empleado);
				da.SelectCommand.Parameters.AddWithValue("@pa_mes", pa_mes);
				da.Fill(ds, "pa_boleta_pago");
				return ds;
			}
			catch (Exception)
			{//Enviar correo al administrador o al programador del error ocurrido
				return null;
			}
		}
}
