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
    public partial class Contratos : System.Web.UI.Page
    {
        ServiceReference1.ServiceClient wcf = new ServiceReference1.ServiceClient();
        DataSet dsDpts = new DataSet();
        DataSet DsEmpleados = new DataSet();
        protected void refreshGvd()
        {
            DsEmpleados = wcf.gvdContrato();
            gvdContratos.DataSource = DsEmpleados;
            gvdContratos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_EmpSinContrato();
                ddlEmpleado.DataSource = dsDpts;
                ddlEmpleado.DataMember = "pa_EmpSinContrato";
                ddlEmpleado.DataTextField = "fullName";
                ddlEmpleado.DataValueField = "id_empleado";
                ddlEmpleado.DataBind();
            }
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_Plaza();
                ddlPlaza.DataSource = dsDpts;
                ddlPlaza.DataMember = "pa_Plaza";
                ddlPlaza.DataTextField = "plaza";
                ddlPlaza.DataValueField = "id_plaza";
                ddlPlaza.DataBind();
            }
            if (!Page.IsPostBack)
            {
                dsDpts = wcf.pa_Turno_Horario();
                ddlTurno.DataSource = dsDpts;
                ddlTurno.DataMember = "pa_Turno_Horario";
                ddlTurno.DataTextField = "turno";
                ddlTurno.DataValueField = "id_turno";
                ddlTurno.DataBind();
            }
            if (!Page.IsPostBack)
            {
                refreshGvd();
            } 
        }

        protected void btnInsertarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                //Validación de entrada de datos usando las expresiones regulares
                dsDpts = wcf.pa_Contrato(int.Parse(ddlEmpleado.SelectedValue), int.Parse(ddlPlaza.SelectedValue), int.Parse(ddlTurno.SelectedValue),int.Parse(txtHoras.Text),double.Parse(txtSalario.Text));
                refreshGvd();
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