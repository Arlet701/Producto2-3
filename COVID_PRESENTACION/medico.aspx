<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="medico.aspx.cs" Inherits="COVID_PRESENTACION.medico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Nombre:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido Paterno:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido Materno:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Telefono:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Correo:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Horario:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Especialidad:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Extra:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Añadir" OnClick="Button1_Click" />
    </p>
</asp:Content>
