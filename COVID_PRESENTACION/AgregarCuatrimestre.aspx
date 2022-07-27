<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarCuatrimestre.aspx.cs" Inherits="COVID_PRESENTACION.Cuatrimestre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Periodo:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Año:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Debe especificar el año" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    </p>
    <p>
        Inicio(yyyy-mm-dd):
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Fin(yyyy-mm-dd):<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Extra: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añadir Cuatrimestre" />
    </p>
</asp:Content>
