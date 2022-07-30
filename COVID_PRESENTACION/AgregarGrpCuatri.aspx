<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AgregarGrpCuatri.aspx.cs" Inherits="COVID_PRESENTACION.GrpCuatri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h2>Formulario para agregar un grupo a un cuatrimestre</h2>
    <div class="container">
        <div class="form-group">
            <p>
                &nbsp;</p>
            <p>
                Programa Educativo:
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            &nbsp;</p>
            <p>
        </div>
        <div class="form-group">

            Grupo:
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            Cuatrimestre:
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            <p>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Obligatorio responder" ForeColor="#F40000" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
            </p>
        </div>  
            <p>
                Turno:
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
        <br />
            <p>
                Modalidad:&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </p>
            <br />
        <div class="form-group">
            <p>
                Extra:
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary"  OnClick="Button1_Click" Text="Añadir Grupo Cuatrimestre" />
            </p>
        </div>
    </div>        
</asp:Content>
