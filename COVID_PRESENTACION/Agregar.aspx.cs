using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COVID_PRESENTACION
{
    public partial class Agregar1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona para añadir");
                DropDownList1.Items.Add("Alumno");
                DropDownList1.Items.Add("Profesor");
                DropDownList1.Items.Add("Cuatrimestre");
                DropDownList1.Items.Add("Grupo Cuatrimestre");
                DropDownList1.Items.Add("Alumno Grupo");
                DropDownList1.Items.Add("Profe Grupo");
                DropDownList1.Items.Add("positivo Profe");
                DropDownList1.Items.Add("positivo Alumno");
                DropDownList1.Items.Add("Seguimiento PRO");
                DropDownList1.Items.Add("Seguimiento AL");
                DropDownList1.Items.Add("Medico");
                DropDownList1.Items.Add("Incapacidad");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Alumno")
            {
                Response.Redirect("AgregarAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profesor")
            {
                Response.Redirect("AgregarProfesor.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Cuatrimestre")
            {
                Response.Redirect("AgregarCuatrimestre.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Grupo Cuatrimestre")
            {
                Response.Redirect("AgregarGrpCuatri.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Alumno Grupo")
            {
                Response.Redirect("AgregarAlumnoGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profe Grupo")
            {
                Response.Redirect("AgregarProfeGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Profe")
            {
                Response.Redirect("AgregarposProfe.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Alumno")
            {
                Response.Redirect("AgregarposAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento PRO")
            {
                Response.Redirect("Agregarsegprof.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento AL")
            {
                Response.Redirect("Agregarsegalum.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Medico")
            {
                Response.Redirect("Agregarmedico.aspx");
            }
            else if (DropDownList1.SelectedItem.Text=="Incapacidad")
            {
                Response.Redirect("AgregarIncapacidad.aspx");
            }
        }
    }
}