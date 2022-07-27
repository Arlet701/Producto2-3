using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;
using System.Data;
using System.Data.SqlClient;

namespace COVID_PRESENTACION
{
    public partial class Consulta : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona la consulta");
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
                GridView1.DataSource = op.Alum(); 
                GridView1.DataBind();

            }
            else if (DropDownList1.SelectedItem.Text == "Profesor")
            {
                GridView1.DataSource = op.Profe();
                GridView1.DataBind();

            }
            else if (DropDownList1.SelectedItem.Text == "Cuatrimestre")
            {
                GridView1.DataSource = op.Cuatri();
                GridView1.DataBind();

            }
            else if (DropDownList1.SelectedItem.Text == "Grupo Cuatrimestre")
            {
                GridView1.DataSource = op.GrupoCuatri();
                GridView1.DataBind();

            }
            else if (DropDownList1.SelectedItem.Text == "Alumno Grupo")
            {
                GridView1.DataSource = op.AluGru();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "Profe Grupo")
            {
                GridView1.DataSource = op.ProfeGru();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Profe")
            {
                GridView1.DataSource = op.Profpos();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "positivo Alumno")
            {
                GridView1.DataSource = op.Alpos();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento PRO")
            {
                GridView1.DataSource = op.ProSeg();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "Seguimiento AL")
            {
                GridView1.DataSource = op.AlSeg();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "Medico")
            {
                GridView1.DataSource = op.Med();
                GridView1.DataBind();
            }
            else if (DropDownList1.SelectedItem.Text == "Incapacidad")
            {
                GridView1.DataSource = op.Inc();
                GridView1.DataBind();
            }
        }
    }
}