<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarAlumno.aspx.cs" Inherits="COVID_PRESENTACION.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para agregar alumnos</h2>
    <div class="container">
        <div class="form-group">
         Matrícula:
         <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
              <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo matrícula obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
              <br />
              <br />

        </div>
        <div class="form-group">
             Nombre:&nbsp;
             <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo nombre obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
             <br />
             <br />

        </div>
        <div class="form-group">
              Apellido Paterno:&nbsp;
             <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Campo apellido es obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
             <br />
             <br />
        </div>
        <div class="form-group">
             Apellido Materno:&nbsp;
             <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Campo apellido es obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
             <br />
             <br />
        </div>
        <div class="form-group">
             Género:&nbsp;
              <asp:DropDownList ID="DropDownList1" runat="server">
              </asp:DropDownList>
             <br />
             <br />
        </div>
         <div class="form-group">
             Correo:&nbsp;
             <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
             <br />
             <br />
        </div>
        <div class="form-group">
              Celular:&nbsp;
            <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
              <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox7" ErrorMessage="*No puede ingresar letras" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
              <br />
              <br />
       </div>
        <div class="form-group">
             Estado Civil:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox>
              <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox9" ErrorMessage="*Ingrese números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
              <br />
              <br />
        </div>
        <div class="form-group">
             <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Añadir" OnClick="Button2_Click"/>
            <br />
            <br />
            <br />
        </div>
    
   </div>
</asp:Content>