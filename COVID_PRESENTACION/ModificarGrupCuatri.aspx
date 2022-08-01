<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarGrupCuatri.aspx.cs" Inherits="COVID_PRESENTACION.ModificarGrupCuatri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para actualizar datos</h2>
    <p>Escribe el id de GrupoCuatri para modificar*</p>
    <div class="container">
        <div class="form-group">
            <p>
                IdGrupoCuatri: 
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Programa Educativo:
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Grupo:
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Id
                Cuatrimestre:
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Ingrese el id" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
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
        <div class="form-group">
            <p>
                Extra (opcional):
                <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Actualizar Grupo Cuatrimestre" />
            </p>
        </div>
    </div>
</asp:Content>
