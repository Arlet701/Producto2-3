<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="COVID_PRESENTACION.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
             <link href="Estilos/Estilo.css" rel="stylesheet" />
            <br />
            <br />
            <br />
            Seleccione para eliminar:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        <div class="form-group">
            <asp:Button Id="Button1" runat="server" class="btn btn-primary" Text="Consulta para eliminar" OnClick="Button1_Click" />
    
        </div>
    </div>
</asp:Content>
