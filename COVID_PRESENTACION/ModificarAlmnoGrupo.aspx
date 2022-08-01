<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarAlmnoGrupo.aspx.cs" Inherits="COVID_PRESENTACION.ModificarAlmnoGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <h2>Formulario para actualizar datos</h2>
    <div class="container">
        <div class="form-group">
            <p>
                Ingrese solo el Id del Alumno para modificar*</p>
            <p>
                IdGrupoCuatri: 
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Alumno:&nbsp;
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Grupo Cuatrimeste:&nbsp;
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Extra 1 (opcional):&nbsp; <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Extra 2 (opcional):&nbsp; <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                &nbsp;
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Actualizar Alumno Grupo" OnClick="Button1_Click" />
            </p>
        </div>
    </div>
</asp:Content>
