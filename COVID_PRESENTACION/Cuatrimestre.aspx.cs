using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class Cuatrimestre : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona para añadir");
                DropDownList1.Items.Add("Enero - Abril");
                DropDownList1.Items.Add("Mayo - Agosto");
                DropDownList1.Items.Add("Septiembre - Diciembre");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Periodo = DropDownList1.SelectedValue;
            int anio = Convert.ToInt32(TextBox1.Text);
            string inicio = TextBox2.Text;
            string Fin = TextBox3.Text;
            string Extra = TextBox4.Text;

            op.AgregaCuat(Periodo, anio, inicio, Fin, Extra);
            Response.Write("<script>alert('Cuatrimestre registrado exitosamente');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox2.Text) && String.IsNullOrEmpty(TextBox3.Text) && String.IsNullOrEmpty(TextBox4.Text))
            {
                string Periodo = DropDownList1.SelectedValue;
                int Anio = Convert.ToInt32(TextBox1.Text);
                op.EliminaCuatri(Periodo, Anio);
                Response.Write("<script>alert('Cuatrimestre eliminado exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Solo escribe el PERIODO y el AÑO');</script>");
            }
        }
    }
}