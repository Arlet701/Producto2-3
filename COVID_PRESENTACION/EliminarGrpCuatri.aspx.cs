using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarGrpCuatri : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Seleccione para añadir");
                DropDownList1.Items.Add("Matutino");
                DropDownList1.Items.Add("Vespertino");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {
                Response.Write("<script>alert('Solo escribe el Programa Educativo, Grupo y Turno');</script>");
            }
            else
            {
                int ProgEd = Convert.ToInt32(TextBox1.Text);
                int F_Grupo = Convert.ToInt32(TextBox2.Text);
                string Turno = DropDownList1.SelectedValue;
                op.EliminaGrpCuat(ProgEd, F_Grupo, Turno);
                Response.Write("<script>alert('Grupo - Cuatrimestre eliminado exitosamente');</script>");
            }
        }
    }
}