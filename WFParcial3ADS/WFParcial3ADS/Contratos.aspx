<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contratos.aspx.cs" Inherits="WFParcial3ADS.Contratos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <title>Contratos</title>
</head>
<body>
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="card text-center">
                <h1 class="card-header text-white" style="background-color: #039be5">Registro de Contratos</h1>
                <div class="card-body">
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Empleado</div>
                        <div class="col-3">
                            <asp:DropDownList ID="ddlEmpleado" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Plaza</div>
                        <div class="col-3">
                            <asp:DropDownList ID="ddlPlaza" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Turno</div>
                        <div class="col-3">
                            <asp:DropDownList ID="ddlTurno" runat="server" AutoPostBack="True"></asp:DropDownList>
                        </div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Horas a la semana</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtHoras" runat="server" type="number" /></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Salario base</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtSalario" runat="server" type="number" />
                        </div>
                        <div class="col-3"></div>
                    </div>                    
                    <br />
                    <div class="row">
                        <div class="col-4">
                            <asp:Label ID="lblError" runat="server"></asp:Label>
                        </div>
                        <div class="col-4">
                            <asp:Button ID="btnInsertarContrato" class="btn btn-primary btn-lg btn-block" runat="server" Text="Crear contrato" OnClick="btnInsertarContrato_Click" /></div>
                        <div class="col-4"></div>
                    </div>
                    <br />
                    <div class="card">
                        <div class="card-body">
                            Aquí dentro va la tablita
                        </div>
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
