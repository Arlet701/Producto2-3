<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="COVID_PRESENTACION.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          Para eliminar solo escribe la matrícula<br />
      <br />
     Matricula:
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <br />
     <br />
     Nombre:&nbsp;
     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          <br />
     <br />
     Apellido Paterno:&nbsp;
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
          <br />
     <br />
     Apellido Materno:&nbsp;
     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
          <br />
     <br />
     Genero:&nbsp;
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
     <br />
     <asp:Button ID="Button2" runat="server" Text="Añadir" OnClick="Button2_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />
&nbsp; &nbsp;
    <br />
    <br />
    <br />
</asp:Content>