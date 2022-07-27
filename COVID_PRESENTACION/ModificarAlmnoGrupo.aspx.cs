using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarAlmnoGrupo : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ID_AlumnGru = Convert.ToInt32(TextBox1.Text);
            int F_Alumno = Convert.ToInt32(TextBox2.Text);
            int F_GruCuat = Convert.ToInt32(TextBox3.Text);
            string Extra1 = TextBox4.Text;
            string Extra2 = TextBox5.Text;
            op.ModificarAlGrp(ID_AlumnGru, F_Alumno, F_GruCuat, Extra1, Extra2);
            Response.Write("<script>alert('Alumno - Grupo actualizado exitosamente');</script>");
        }
    }
}