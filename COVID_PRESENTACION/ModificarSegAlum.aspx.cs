using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarSegAlum : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id_Seguimiento = Convert.ToInt32(TextBox1.Text);
            int F_positivoAL = Convert.ToInt32(TextBox2.Text);
            int F_medico = Convert.ToInt32(TextBox3.Text);
            string Fecha = TextBox4.Text;
            string Form_Comunica = TextBox5.Text;
            string Reporte = TextBox6.Text;
            string Entrevista = TextBox7.Text;
            string Extra = TextBox8.Text;

            op.ModificarSegAL(Id_Seguimiento, F_positivoAL, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
            Response.Write("<script>alert('Seguimiento Alumno actualizado exitosamente');</script>");
        }
    }
}