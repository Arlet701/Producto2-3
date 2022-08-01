<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EliminarProfeGrupo.aspx.cs" Inherits="COVID_PRESENTACION.EliminarProfeGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <h2>Formulario para eliminar</h2>
    <div class="container">
        <div class="form-group">
            <p>
                Profesor:&nbsp;
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button1_Click" />
            </p>
        </div>
    </div>
</asp:Content>
