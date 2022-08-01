<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Agregarmedico.aspx.cs" Inherits="COVID_PRESENTACION.medico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar médicos</h2>
    <div class="container">
        <div class="form-group">
            <p>
                Nombre:
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Apellido Paterno:<asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
             Apellido Materno:
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo obligatorio" ForeColor="#F40000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                 Teléfono:<asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Ingrese números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Correo:<asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Horario:<asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>    
        <div class="form-group">
            <p>
                Especialidad:<asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>   
        <div class="form-group">
            <p>
                Extra (opcional):<asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>  
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Añadir" OnClick="Button1_Click" />
            </p>
        </div>   
    </div>            
</asp:Content>
