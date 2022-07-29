<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AlSegMat.aspx.cs" Inherits="COVID_PRESENTACION.AlSegMat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Periodo:
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    &nbsp;<br />
    Matricula:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consulta" />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
</asp:Content>
