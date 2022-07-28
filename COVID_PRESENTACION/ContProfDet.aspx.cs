using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ContProfDet : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre = TextBox1.Text;
            string Ap_pat = TextBox2.Text;
            string Ap_Mat = TextBox3.Text;
            GridView1.DataSource = op.ConsultaContPro(Nombre, Ap_pat, Ap_Mat);
            GridView1.DataBind();
        }
    }
}