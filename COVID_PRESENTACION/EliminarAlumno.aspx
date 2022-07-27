<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EliminarAlumno.aspx.cs" Inherits="COVID_PRESENTACION.EliminarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Escribe la matrícula que deseas eliminar:</p>
    <p>
        Matrícula:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Eliminar Alumno" OnClick="Button1_Click" />
    </p>

</asp:Content>
