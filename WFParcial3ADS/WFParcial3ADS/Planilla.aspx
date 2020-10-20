<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Planilla.aspx.cs" Inherits="WFParcial3ADS.Planilla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <title>Planilla</title>
</head>
<body>
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="card text-center">
                <h1 class="card-header text-white" style="background-color: #039be5">Registro de Asistencia mensual</h1>
                <div class="card-body">
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Empleado</div>
                        <div class="col-3">
                            <asp:DropDownList ID="ddlEmpleado" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Mes</div>
                        <div class="col-3">
                            <asp:DropDownList ID="ddlMes" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Dias asistidos</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtDias" runat="server" type="number" /></div>
                        <div class="col-3"></div>
                    </div>
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col-3">Total horas realizadas</div>
                        <div class="col-3">
                            <asp:TextBox ID="txtHoras" runat="server" type="number" />
                        </div>
                        <div class="col-3"></div>
                    </div>                    
                    <br />
                    <div class="row">
                        <div class="col-4"></div>
                        <div class="col-4">
                            <asp:Button ID="btnInsertarPlanilla" class="btn btn-primary btn-lg btn-block" runat="server" Text="Insertar asistencia y crear planilla" /></div>
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
