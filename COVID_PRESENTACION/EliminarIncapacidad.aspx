<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EliminarIncapacidad.aspx.cs" Inherits="COVID_PRESENTACION.EliminarIncapacidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <h2>Formulario para eliminar</h2>
    <div class="container">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Periodo: "></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <p>
                <asp:Label ID="Label2" runat="server" Text="Comprobación: "></asp:Label>
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Eliminar" />
            </p>
        </div>
    </div>
</asp:Content>
