using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;
using System.Data;
using System.Data.SqlClient;

namespace COVID_PRESENTACION
{
    public partial class Consulta : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Selecciona la consulta");
            DropDownList1.Items.Add("Estado Civil");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Estado Civil")
            {

                DataTable Tabla = op.Civil();
                GridView1.DataSource = Tabla;
                GridView1.DataBind();

            }
        }
    }
}