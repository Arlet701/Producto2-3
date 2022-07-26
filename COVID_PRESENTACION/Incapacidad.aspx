<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Incapacidad.aspx.cs" Inherits="COVID_PRESENTACION.Incapacidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Periodo:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Comprobación:&nbsp;
    </p>
    <p>
        Extra:&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Profesor:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
</asp:Content>
