<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="WFParcial3ADS.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <title>Registro de Empleados</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card text-center">
                <h1 class="card-header text-white" style="background-color: #039be5">Registro de Empleados</h1>
                <div class="card-body">
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Nombres</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Apellidos</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Fecha de nacimiento</div>
                        <div class="col-3"> <asp:TextBox ID="datFecha" runat="server" Format="yyyy/MM/dd" TextMode="Date"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Correo electrónico</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">DUI</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtDui" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">NIT(si posee)</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtNit" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Teléfono</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Dirección</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></div>
                        <div class="col-3"></div>
                    </div>
                </div>
                <div class="card-footer text-muted" style="background-color: #eceff1">
                    Análisis y Diseño de Sistemas de Información - 2020
                </div>
            </div>
        </div>
    </form>
</body>
</html>
