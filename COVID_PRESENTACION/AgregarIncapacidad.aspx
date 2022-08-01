<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarIncapacidad.aspx.cs" Inherits="COVID_PRESENTACION.AgregarIncapacidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar incapacidad</h2>
    <div class="container">
            <asp:Label ID="Label1" runat="server" Text="Periodo: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Comprobación:"></asp:Label>
            &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" />
            <br />
            <br />
        <div class="form-group">
            Extra(Opcional):<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="form-group">
            Id 
            <asp:Label ID="Label4" runat="server" Text="Profesor positivo: "></asp:Label>
            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*" ControlToValidate="TextBox4"></asp:RegularExpressionValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>  
        <div class="form-group">
             <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Añadir" />
        </div>   
    </div>
</asp:Content>
