<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarAlumnoGrupo.aspx.cs" Inherits="COVID_PRESENTACION.AlumnoGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar alumnos a un grupo</h2>
     <div class="container">
        <div class="form-group">
            <p>
            &nbsp;</p>
            <p>
                Alumno:&nbsp;
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>

            </p>
            <p>
              &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*" ControlToValidate="TextBox1"></asp:RegularExpressionValidator>
            </p>
         </div>
         <div class="form-group">
            <p>
                Grupo Cuatrimeste:&nbsp;
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
            </p>
          </div>
          <div class="form-group">
              <p>
                Extra(opcional): <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
          </div>
          <div class="form-group">
              <p>
                Extra 2(opcional):&nbsp;
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
          </div>
         <div class="form-group">
             <p>
                &nbsp;
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Añadir Alumno Grupo" OnClick="Button1_Click" />
            </p>
         </div>
      </div>   
</asp:Content>
