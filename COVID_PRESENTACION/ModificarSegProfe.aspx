<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarSegProfe.aspx.cs" Inherits="COVID_PRESENTACION.ModificarSegProfe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para actualizar datos</h2>
    <p>Ingrese el IdSeguimientoProfesor para actualizar*</p>
    <div class="container">
        <div class="form-group">
            <p>
                IDSeguimientoProfesor:&nbsp;
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
                Profesor:&nbsp;
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Médico:
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Fecha (yyyy-mm-dd):
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Medio de comunicación:&nbsp;
                <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Reporte:
                <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Entrevista:
                <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
             <p>
                Extra (opcional):
                <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Actualizar" />
            </p>
        </div>
    </div>
</asp:Content>
