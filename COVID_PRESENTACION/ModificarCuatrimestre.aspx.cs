using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarCuatrimestre : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona para actualizar");
                DropDownList1.Items.Add("Enero - Abril");
                DropDownList1.Items.Add("Mayo - Agosto");
                DropDownList1.Items.Add("Septiembre - Diciembre");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Periodo = DropDownList1.SelectedValue;
            int Anio = Convert.ToInt32(TextBox1.Text);
            string Inicio = TextBox2.Text;
            string Fin = TextBox3.Text;
            string Extra = TextBox4.Text;

            op.ModificarCuat(Periodo, Anio, Inicio, Fin, Extra);
            Response.Write("<script>alert('Cuatrimestre actualizado exitosamente');</script>");
        }
    }
}