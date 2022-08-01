using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarIncapacidad : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {
                Response.Write("<script>alert('Debe llenar los campos solicitados');</script>");
            }
            else
            {
                string Periodo = TextBox1.Text;
                int F_positivoProfe = Convert.ToInt32(TextBox2.Text);
                op.EliminarIncap(Periodo, F_positivoProfe);
                Response.Write("<script>alert('Tipo de incapacidad eliminado exitosamente');</script>");
            }
        }
    }
}