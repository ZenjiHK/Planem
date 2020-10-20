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
    public partial class Planilla : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient wcf = new ServiceReference1.ServiceClient();
        DataSet dsDpts = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_EmpleadosList();
                ddlEmpleado.DataSource = dsDpts;
                ddlEmpleado.DataMember = "pa_EmpleadosList";
                ddlEmpleado.DataTextField = "fullName";
                ddlEmpleado.DataValueField = "id_empleado";
                ddlEmpleado.DataBind();
            }
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_Mes();
                ddlMes.DataSource = dsDpts;
                ddlMes.DataMember = "pa_Mes";
                ddlMes.DataTextField = "mes";
                ddlMes.DataValueField = "id_mes";
                ddlMes.DataBind();
            }
        }

        protected void btnInsertarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de entrada de datos usando las expresiones regulares
                dsDpts = wcf.pa_boleta_pago(int.Parse(txtDias.Text), double.Parse(txtHoras.Text), int.Parse(ddlEmpleado.SelectedValue), int.Parse(ddlMes.SelectedValue));
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
    }
}