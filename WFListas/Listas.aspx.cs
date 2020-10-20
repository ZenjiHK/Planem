using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WFListas
{
    public partial class Listas : System.Web.UI.Page
    {
        Servicio.ServiceClient listas = new Servicio.ServiceClient();
        DataSet dsDepartamentos = new DataSet();
        DataSet dsMunicipios = new DataSet();
        DataSet dsMuni = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlMunicipio.Enabled = false;
            if (!Page.IsPostBack)
            {
                dsDepartamentos = listas.SP_ShowDepa();
                ddlDepartamento.DataSource = dsDepartamentos;
                ddlDepartamento.DataMember = "Departamentos";
                ddlDepartamento.DataTextField = "departamento";
                ddlDepartamento.DataValueField = "id_departamento";
                ddlDepartamento.DataBind();
                CargarDatos();
            }
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMunicipio.Enabled = true;
            dsMunicipios = listas.SP_ShowMuni(int.Parse(ddlDepartamento.SelectedValue));
            ddlMunicipio.DataSource = dsMunicipios;
            ddlMunicipio.DataMember = "Municipios";
            ddlMunicipio.DataTextField = "municipio";
            ddlMunicipio.DataValueField = "id_municipio";
            ddlMunicipio.DataBind();
        }

        protected void gvMunicipios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMunicipios.PageIndex = e.NewPageIndex;
            CargarDatos();
        }

        protected void CargarDatos()
        {
            dsMuni = listas.SP_ShowAllMuni();
            gvMunicipios.DataSource = dsMuni;
            gvMunicipios.DataMember = dsMuni.Tables[0].TableName;
            gvMunicipios.DataBind();
        }
    }
}