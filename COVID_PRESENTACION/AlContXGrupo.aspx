<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AlContXGrupo.aspx.cs" Inherits="COVID_PRESENTACION.AlContXGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Grado:
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    Grupo:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
    <br />
    Programa educativo:
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <br />
    Carrera:
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
    &nbsp;<br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consulta" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />

</asp:Content>
