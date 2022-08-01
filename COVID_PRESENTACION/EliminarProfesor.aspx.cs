using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarProfesor : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {
              
                Response.Write("<script>alert('Escribe el Nombre y Apellido Paterno');</script>");
            }
            else
            { 
                string Nombre = TextBox1.Text;
                string App = TextBox2.Text;
                op.EliminaProfe(Nombre, App);
                Response.Write("<script>alert('Profesor eliminado exitosamente');</script>");
            }
        }
    }
}