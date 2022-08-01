using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class segprof : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int F_positivoProfe = Convert.ToInt32(TextBox1.Text);
            int F_medico = Convert.ToInt32(TextBox2.Text);
            string Fecha = TextBox3.Text;
            string Form_Comunica = TextBox4.Text;
            string Reporte = TextBox5.Text;
            string Entrevista = TextBox6.Text;
            string Extra = TextBox7.Text;

            op.AgregaSegPro(F_positivoProfe, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
            Response.Write("<script>alert('Profesor registrado exitosamente');</script>");
        }

    }
}