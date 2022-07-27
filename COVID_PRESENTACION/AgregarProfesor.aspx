<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarProfesor.aspx.cs" Inherits="COVID_PRESENTACION.Profesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <br />
              Registro Empleado:
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ControlToValidate="TextBox1" ForeColor="#F40000"></asp:RequiredFieldValidator>
          <br />
     <br />
     Nombre:&nbsp;
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
          <br />
     <br />
     Apellido Paterno:&nbsp;
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
              <br />
     <br />
     Apellido Materno:&nbsp;
     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
          <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
              <br />
     <br />
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
     Correo:&nbsp;
     <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
          <br />
     <br />
     Celular:&nbsp;
     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
          <br />
     <br />
     Estado Civil:&nbsp;&nbsp;
     <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
              <br />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
          <br />
     <br />
     <asp:Button ID="Button2" runat="server" Text="Añadir" OnClick="Button2_Click"/>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
</asp:Content>
