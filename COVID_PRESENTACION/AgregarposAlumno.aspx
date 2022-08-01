<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarposAlumno.aspx.cs" Inherits="COVID_PRESENTACION.posAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar alumnos con covid</h2>
    <div class="container">
        <div class="form-group">
            <p>
            Fecha Confirmado:
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
             Comprobacion:
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
             <p>
                Antecedentes:<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
            </p>
        </div>      
           
            <p>
                Riesgo: <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
        <div class="form-group">
            <p>
                Número de contagio:
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
                <p>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Ingrese números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Extra(opcional):
                <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Alumno:
                <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Añadir" OnClick="Button1_Click" />
            </p>
        </div>
    </div>
</asp:Content>
