<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarProfesor.aspx.cs" Inherits="COVID_PRESENTACION.Profesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar profesores</h2>
    <div class="container">
        <div class="form-group">
                      <br />
                      Registro Empleado:
             <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Solo se permiten números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ControlToValidate="TextBox1" ForeColor="#F40000"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Nombre:&nbsp;
             <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Apellido Paterno:&nbsp;
             <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                      <br />
             <br />
        </div>
        <div class="form-group">
             Apellido Materno:&nbsp;
             <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                      <br />
             <br />
            </div>
             Genero:&nbsp;
                      <asp:DropDownList ID="DropDownList2" runat="server">
                      </asp:DropDownList>
                      <br />
                      <br />
                      Categoría:
                      <asp:DropDownList ID="DropDownList1" runat="server">
                      </asp:DropDownList>
                  <br />
             <br />
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
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Ingrese números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Estado Civil:&nbsp;&nbsp;
             <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox>
                      &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox9" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                      <br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Añadir" OnClick="Button2_Click"/>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
