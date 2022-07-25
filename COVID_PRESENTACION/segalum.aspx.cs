using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class segalum : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int F_positivoAL = Convert.ToInt32(TextBox1.Text);
            int F_medico = Convert.ToInt32(TextBox2.Text);
            string Fecha = TextBox3.Text;
            string Form_Comunica = TextBox4.Text;
            string Reporte = TextBox5.Text;
            string Entrevista = TextBox6.Text;
            string Extra = TextBox7.Text;

            op.AgregaSegAL(F_positivoAL, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
            Response.Write("<script>alert('Seguimiento Alumno registrado exitosamente');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox2.Text) && String.IsNullOrEmpty(TextBox4.Text) && String.IsNullOrEmpty(TextBox5.Text)
                && String.IsNullOrEmpty(TextBox6.Text) && String.IsNullOrEmpty(TextBox7.Text))
            {
                int F_PositivoAL = Convert.ToInt32(TextBox1.Text);
                string FechaConfirmado = TextBox3.Text;
                op.EliminaSegAL(F_PositivoAL, FechaConfirmado);
                Response.Write("<script>alert('Seguimiento Alumno eliminado exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Solo escribe al ALUMNO y la FECHA');</script>");
            }
        }
    }
}