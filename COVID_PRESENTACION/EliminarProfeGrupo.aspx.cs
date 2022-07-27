using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarProfeGrupo : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text))
            {
               Response.Write("<script>alert('Solo escribe al PROFE');</script>");
            }
            else
            {
                int F_Profe = Convert.ToInt32(TextBox1.Text);
                op.EliminaProGrp(F_Profe);
                Response.Write("<script>alert('Profesor - Grupo eliminado exitosamente');</script>");
                
            }
        }
    }
}