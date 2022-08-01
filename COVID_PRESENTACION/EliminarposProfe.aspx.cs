using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class EliminarposProfe : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {

                Response.Write("<script>alert('Solo escribe la FECHA y el PROFE');</script>");
            }
            else
            {
                string FechaConfirmado = TextBox1.Text;
                int F_Profe = Convert.ToInt32(TextBox2.Text);
                op.EliminaProPos(FechaConfirmado, F_Profe);
                Response.Write("<script>alert('Profesor positivo eliminado exitosamente');</script>");
            }
        }
    }
}