<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="COVID_PRESENTACION.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="Estilos/Estilo.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    Seleccione para eliminar:
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Button Id="Button1" runat="server" Text="Consulta para eliminar" OnClick="Button1_Click" />

</asp:Content>
