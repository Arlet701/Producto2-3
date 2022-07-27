using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarGrupCuatri : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Seleccione para añadir");
                DropDownList1.Items.Add("Matutino");
                DropDownList1.Items.Add("Vespertino");

                DropDownList2.Items.Add("Seleccione para añadir");
                DropDownList2.Items.Add("Presencial");
                DropDownList2.Items.Add("En línea");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id_GruCuat = Convert.ToInt32(TextBox1.Text);
            int F_ProgEd = Convert.ToInt32(TextBox2.Text);
            int F_Grupo = Convert.ToInt32(TextBox3.Text);
            int F_Cuatri = Convert.ToInt32(TextBox4.Text);
            string Turno = DropDownList1.SelectedValue;
            string Modalidad = DropDownList2.SelectedValue;
            string Extra = TextBox5.Text;

            op.ModificarGrpCuat(Id_GruCuat,F_ProgEd, F_Grupo, F_Cuatri, Turno, Modalidad, Extra);
            Response.Write("<script>alert('Grupo Cuatrimestre actualizado exitosamente');</script>");
        }
    }
}