using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class AlSegMat : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropDownList1.Items.Add("Selecciona el Periodo");
                DropDownList1.Items.Add("Enero - Abril");
                DropDownList1.Items.Add("Mayo - Agosto");
                DropDownList1.Items.Add("Septiembre - Diciembre");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Periodo = DropDownList1.SelectedValue;
            string Matricula = TextBox1.Text;
            GridView1.DataSource = op.ConsultaSegAL(Periodo, Matricula);
            GridView1.DataBind();
        }
    }
}