<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="COVID_PRESENTACION.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <asp:Label ID="Label1" runat="server" Text="Seleccione para actualizar: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Consulta para actualizar" />
        </div>
    </div>
</asp:Content>
