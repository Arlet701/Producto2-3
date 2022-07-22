<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="COVID_PRESENTACION.Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Estilos/Estilo.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    Selecciona la consulta:
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
    </asp:Content>
