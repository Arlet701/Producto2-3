<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ModificarCuatrimestre.aspx.cs" Inherits="COVID_PRESENTACION.ModificarCuatrimestre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Formulario para actualizar datos</h2>
    <p>Escribe el periodo y el año a modificar*</p>
    <div class="container">
             <p>
                Periodo: <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
        <div class="form-group">
            <p>
                Año:
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Debe ingresar números" ForeColor="#F40000" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </p>
             <p>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo obligatorio" ForeColor="#F40000"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <p>
                Inicio(yyyy-mm-dd):
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Fin(yyyy-mm-dd):<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                Extra (opcional): <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </p>
        </div>
        <div class="form-group">
            <p>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Actualizar" />
            </p>
        </div>
    </div>
</asp:Content>
