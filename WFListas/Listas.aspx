<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listas.aspx.cs" Inherits="WFListas.Listas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Lato&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <div class="card text-center">
                <h1 class="card-header text-white" style="background-color: #039be5">Ejemplo de lista desplegable y Paginación</h1>
                <div class="card-body" style="background-color: #e1f5fe">
                    <div class="row">
                        <div class="col-6">
                            <div style="font-family: 'Lato', sans-serif; font-size: 20px">
                                <div class="card" style="height: 100%">
                                    <h3 class="card-header text-white" style="background-color: #039be5">Listas anidadas</h3>
                                    <div class="card-body">
                                        <br />
                                        Departamentos:
                                        <br />
                                        <asp:DropDownList ID="ddlDepartamento" runat="server" Style="width: 80%; font-size: 18px"
                                            OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:DropDownList><br />
                                        <br />
                                        <br />
                                        Municipios:
                                        <br />
                                        <asp:DropDownList ID="ddlMunicipio" runat="server" Style="width: 80%; font-size: 18px">
                                        </asp:DropDownList><br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-6 text-center">
                            <div class="card">
                                <h3 class="card-header text-white" style="background-color: #039be5">Paginación</h3>
                                <div class="card-body">
                                    <asp:GridView ID="gvMunicipios" runat="server" OnPageIndexChanging="gvMunicipios_PageIndexChanging" class="table table-bordered table-sm"
                                        ShowFooter="True" Width="100%" AllowSorting="True" AllowPaging="true" PageSize="6" Style="background-color: white">
                                        <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" />
                                    </asp:GridView>
                                </div>
                            </div>

                        </div>
                    </div>

                </div>
                <div class="card-footer text-muted" style="background-color: #eceff1">
                    Análisis y Diseño de Sistemas de Información - 2020
                </div>
            </div>
            <br />

        </div>
    </form>
</body>
</html>
