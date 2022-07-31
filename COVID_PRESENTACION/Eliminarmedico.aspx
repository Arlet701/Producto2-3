﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Eliminarmedico.aspx.cs" Inherits="COVID_PRESENTACION.Eliminarmedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Nombre:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
    </p>
    <p>
        Apellido Paterno:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
    </p>
    <p>
        Apellido Materno:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Eliminar" OnClick="Button1_Click" />
    </p>
</asp:Content>
