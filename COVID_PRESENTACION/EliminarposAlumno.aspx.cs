using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarposAlumno : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {
                Response.Write("<script>alert('Solo escribe la FECHA y el ALUMNO');</script>");
            }
            else
            {
                string FechaConfirmado = TextBox1.Text;
                int F_Alumno = Convert.ToInt32(TextBox2.Text);
                op.EliminaALPos(FechaConfirmado, F_Alumno);
                Response.Write("<script>alert('Alumno positivo eliminado exitosamente');</script>");
            }
        }
    }
}