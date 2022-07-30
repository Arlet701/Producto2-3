<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarAlumno.aspx.cs" Inherits="COVID_PRESENTACION.ModificarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para actualizar datos</h2>
    <div class="container">
        <div class="form-group">
         Matricula:
             <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Nombre:&nbsp;
             <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
             <br />
        </div>
        <div class="form-group">
             Apellido Paterno:&nbsp;
             <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Apellido Materno:&nbsp;
             <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
             <br />
        </div>
             Género:&nbsp;
                  <asp:DropDownList ID="DropDownList1" runat="server">
                  </asp:DropDownList>
                  <br />
             <br />
        <div class="form-group">
             Correo:&nbsp;
             <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Celular:&nbsp;
             <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
                  <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Debe ingresar números" ForeColor="#F40000"></asp:RegularExpressionValidator>
                  <br />
             <br />
        </div>
        <div class="form-group">
             Estado Civil:&nbsp;&nbsp;
             <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox9" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                  <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox9" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
                  <br />
        </div>
        <div class="form-group">
             <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Actualizar" />
             <br />
        </div>
    </div>
</asp:Content>
