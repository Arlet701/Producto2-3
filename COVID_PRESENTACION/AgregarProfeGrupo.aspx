<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarProfeGrupo.aspx.cs" Inherits="COVID_PRESENTACION.ProfeGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar profesores a un grupo</h2>
    <div class="container">
         <div class="form-group">
            <p>
                &nbsp;</p>
            <p>
                Profesor:&nbsp;
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </p>
        </div>
         <div class="form-group">
            <p>
                Grupo Cuatrimeste:&nbsp;
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </p>
        </div>
         <div class="form-group">
            <p>
                Extra :
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
         </div>
         <div class="form-group">
            <p>
                Extra 2:&nbsp;
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
         </div>
         <div class="form-group">
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Añadir Profe Grupo" />
         </div>
   </div>       
</asp:Content>
