<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="WFListas.crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id_municipio" DataSourceID="ds_crud" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Image" CancelImageUrl="~/imgs/atras.png" DeleteImageUrl="~/imgs/delete.png" EditImageUrl="~/imgs/update.png" InsertImageUrl="~/imgs/add.png" ShowDeleteButton="True" ShowEditButton="True" UpdateImageUrl="~/imgs/update.png" />
                    <asp:BoundField DataField="id_municipio" HeaderText="Código" InsertVisible="False" ReadOnly="True" SortExpression="id_municipio" />
                    <asp:BoundField DataField="municipio" HeaderText="Nombre" SortExpression="municipio" />
                    <asp:BoundField DataField="id_departamento" HeaderText="Departamento" SortExpression="id_departamento" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="ds_crud" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Listas_DesplegablesConnectionString %>" DeleteCommand="DELETE FROM [municipios] WHERE [id_municipio] = @original_id_municipio AND (([municipio] = @original_municipio) OR ([municipio] IS NULL AND @original_municipio IS NULL)) AND (([id_departamento] = @original_id_departamento) OR ([id_departamento] IS NULL AND @original_id_departamento IS NULL))" InsertCommand="INSERT INTO [municipios] ([municipio], [id_departamento]) VALUES (@municipio, @id_departamento)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [municipios]" UpdateCommand="UPDATE [municipios] SET [municipio] = @municipio, [id_departamento] = @id_departamento WHERE [id_municipio] = @original_id_municipio AND (([municipio] = @original_municipio) OR ([municipio] IS NULL AND @original_municipio IS NULL)) AND (([id_departamento] = @original_id_departamento) OR ([id_departamento] IS NULL AND @original_id_departamento IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_id_municipio" Type="Int32" />
                    <asp:Parameter Name="original_municipio" Type="String" />
                    <asp:Parameter Name="original_id_departamento" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="municipio" Type="String" />
                    <asp:Parameter Name="id_departamento" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="municipio" Type="String" />
                    <asp:Parameter Name="id_departamento" Type="Int32" />
                    <asp:Parameter Name="original_id_municipio" Type="Int32" />
                    <asp:Parameter Name="original_municipio" Type="String" />
                    <asp:Parameter Name="original_id_departamento" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
