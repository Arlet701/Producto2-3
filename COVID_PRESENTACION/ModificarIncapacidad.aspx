<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarIncapacidad.aspx.cs" Inherits="COVID_PRESENTACION.ModificarIncapacidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para actualizar datos</h2>
    <div class="container">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Periodo: "></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            <br />
        </div>
            <asp:Label ID="Label2" runat="server" Text="Comprobación:"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" />
            <br />
            <br />
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Extra: "></asp:Label>
            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Profesor positivo:"></asp:Label>
            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        <div class="form-group">
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Actualizar" />
        </div>
    </div>
</asp:Content>
