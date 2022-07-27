using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarAlumno : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                Response.Write("<script>alert('Escribe la matricula');</script>");
            }
            else
            {
               string Matricula = TextBox1.Text;
                op.EliminaAlumno(Matricula);
                Response.Write("<script>alert('Alumno eliminado exitosamente');</script>");
            }
                
        }
    }
}