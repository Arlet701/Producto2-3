using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class Eliminarmedico : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox3.Text))
            {
                Response.Write("<script>alert('Solo escribe el NOMBRE y APELLIDOS');</script>");
            }
            else
            {
                string Nombre = TextBox1.Text;
                string App = TextBox2.Text;
                string Apm = TextBox3.Text;
                op.EliminaMed(Nombre, App, Apm);
                Response.Write("<script>alert('Medico eliminado exitosamente');</script>");
            }
        }
    }
}