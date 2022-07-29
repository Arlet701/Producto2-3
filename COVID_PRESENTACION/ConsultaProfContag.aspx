<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ConsultaProfContag.aspx.cs" Inherits="COVID_PRESENTACION.ConsultaProfContag" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Programa educativo:
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    Cuatrimestre:<asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <br />
    Anio:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
    <br />
    Carrera:
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />

</asp:Content>
