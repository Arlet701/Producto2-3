using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class medico : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre = TextBox1.Text;
            string App = TextBox2.Text;
            string Apm = TextBox3.Text;
            string telefono = TextBox4.Text;
            string correo = TextBox5.Text;
            string horario= TextBox6.Text;
            string especialidad = TextBox7.Text;
            string extra = TextBox8.Text;

            op.AgregaMed(Nombre, App, Apm, telefono, correo, horario, especialidad, extra);
            Response.Write("<script>alert('Medico registrado exitosamente');</script>");
        }

    }
}