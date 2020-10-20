using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace WFParcial3ADS
{
    public partial class Empleados : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient wcf = new ServiceReference1.ServiceClient();
        DataSet dsDpts = new DataSet();

        Regex valNombre = new Regex("^[A-Za-záéíóúÁÉÍÓÚñÑ ]{0,100}$");
        Regex valApellido = new Regex("^[A-Za-záéíóúÁÉÍÓÚñÑ ]{0,100}$");
        Regex valEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        Regex valDui = new Regex(@"^\d{8}\-\d$");
        Regex valNit = new Regex(@"^\d{4}\-\d{6}\-\d{3}\-\d{1}$");
        Regex valTelefono = new Regex(@"^\(\d{3}\)\ \d{4}\-\d{4}$");
        Regex valDireccion = new Regex(@"^[A-Za-záéíóúÁÉÍÓÚñÑ #,1-9]{0,250}$");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_Departamento();
                ddlDepartamento.DataSource = dsDpts;
                ddlDepartamento.DataMember = "pa_Departamento";
                ddlDepartamento.DataTextField = "nombre_departamento";
                ddlDepartamento.DataValueField = "id_departamento";
                ddlDepartamento.DataBind();
            }
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_sexo();
                ddlSexo.DataSource = dsDpts;
                ddlSexo.DataMember = "pa_sexo";
                ddlSexo.DataTextField = "sexo";
                ddlSexo.DataValueField = "id_sexo";
                ddlSexo.DataBind();
            }
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsDpts = wcf.pa_SubDepartamento(int.Parse(ddlDepartamento.SelectedValue));
            ddlSubdepartamento.DataSource = dsDpts;
            ddlSubdepartamento.DataMember = "pa_SubDepartamento";
            ddlSubdepartamento.DataTextField = "nombre_subdepartamento";
            ddlSubdepartamento.DataValueField = "id_subdepartamento";
            ddlSubdepartamento.DataBind();
        }

        protected void btnInsertarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de entrada de datos usando las expresiones regulares
                if (!valNombre.IsMatch(txtNombre.Text))
                {
                    lblError.Text = "*Error. Sólo se permiten letras (Máx. 100)";
                    return;
                }
                if (!valApellido.IsMatch(txtApellido.Text))
                {
                    lblError.Text = "*Error. Sólo se permiten letras (Máx. 100)";
                    return;
                }
                if (!valEmail.IsMatch(txtCorreo.Text))
                {
                    lblError.Text = "*Error, el formato de correo no es válido. (Máx. 50)";
                    return;
                }
                if (!valDui.IsMatch(txtDui.Text))
                {
                    lblError.Text = "*Error, el formato de correo no es válido. (Máx. 50)";
                    return;
                }
                if (!valNit.IsMatch(txtNit.Text))
                {
                    lblError.Text = "*Error, el formato de correo no es válido. (Máx. 50)";
                    return;
                }
                if (!valTelefono.IsMatch(txtTelefono.Text))
                {
                    lblError.Text = "*Error, el formato de correo no es válido. (Máx. 50)";
                    return;
                }
                if (!valDireccion.IsMatch(txtDireccion.Text))
                {
                    lblError.Text = "*Error, el formato de correo no es válido. (Máx. 50)";
                    return;
                }

                dsDpts = wcf.pa_NuevoEmpleado(txtNombre.Text, txtApellido.Text,DateTime.Parse(datFecha.Text), txtCorreo.Text,txtDui.Text,txtNit.Text,txtTelefono.Text,txtDireccion.Text, int.Parse(ddlSubdepartamento.SelectedValue), int.Parse(ddlSexo.SelectedValue));
                if (dsDpts != null)
                {
   
                        lblError.Text = "Registro agregado correctamente.";
                }
                else
                    lblError.Text = "*Error. No se pudo ejecutar el proceso de inserción.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        protected void btnContrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contratos.aspx");
        }

        protected void btnPlanilla_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planilla.aspx");
        }
    }
}