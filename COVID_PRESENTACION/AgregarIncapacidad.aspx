﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarIncapacidad.aspx.cs" Inherits="COVID_PRESENTACION.AgregarIncapacidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Periodo: "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Comprobación:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Extra: "></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="F_positivoProfe:"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añadir" />
</asp:Content>
