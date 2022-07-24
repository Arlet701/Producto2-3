using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ProfeGrupo : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int F_Profe = Convert.ToInt32(TextBox1.Text);
            int F_GruCuat = Convert.ToInt32(TextBox2.Text);
            string Extra1 = TextBox3.Text;
            string Extra2 = TextBox4.Text;
            op.AgregaProfGrp(F_Profe, F_GruCuat, Extra1, Extra2);
            Response.Write("<script>alert('Profesor - Cuatrimestre registrado exitosamente');</script>");
        }
    }
}