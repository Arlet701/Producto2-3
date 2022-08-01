using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COVID_PRESENTACION
{
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona para actualizar");
                DropDownList1.Items.Add("Alumno");//Listo
                DropDownList1.Items.Add("Profesor");//Listo
                DropDownList1.Items.Add("Cuatrimestre");//Listo
                DropDownList1.Items.Add("Grupo Cuatrimestre");//Listo
                DropDownList1.Items.Add("Alumno Grupo");//Listo
                DropDownList1.Items.Add("Profe Grupo");//Listo
                DropDownList1.Items.Add("positivo Profe");//Listo
                DropDownList1.Items.Add("positivo Alumno");//Listo
                DropDownList1.Items.Add("Seguimiento PRO");
                DropDownList1.Items.Add("Seguimiento AL");
                DropDownList1.Items.Add("Medico");//Listo
                DropDownList1.Items.Add("Incapacidad");//Listo
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Alumno")
            {
                Response.Redirect("ModificarAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profesor")
            {
                Response.Redirect("ModificarProfesor.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Cuatrimestre")
            {
                Response.Redirect("ModificarCuatrimestre.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Grupo Cuatrimestre")
            {
                Response.Redirect("ModificarGrupCuatri.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Alumno Grupo")
            {
                Response.Redirect("ModificarAlmnoGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Profe Grupo")
            {
                Response.Redirect("ModificarProfeGrupo.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Profe")
            {
                Response.Redirect("ModificarPosProfe.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Alumno")
            {
                Response.Redirect("ModificarPosAlumno.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento PRO")
            {
                Response.Redirect("ModificarSegProfe.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento AL")
            {
                Response.Redirect("ModificarSegAlum.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Medico")
            {
                Response.Redirect("ModificarMedico.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Incapacidad")
            {
                Response.Redirect("ModificarIncapacidad.aspx");
            }
        }
    }
}