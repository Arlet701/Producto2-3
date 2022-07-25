using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class posProfe : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Selecciona para añadir");
            DropDownList1.Items.Add("Muy Alto");
            DropDownList1.Items.Add("Alto");
            DropDownList1.Items.Add("Medio");
            DropDownList1.Items.Add("Bajo");
            DropDownList1.Items.Add("Muy Bajo");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string FechaConfirmado = TextBox1.Text;
            string Comprobacion = TextBox2.Text;
            string Antecedentes = TextBox3.Text;
            string Riesgo = DropDownList1.SelectedValue;
            int NumContaio = Convert.ToInt32(TextBox4.Text);
            string Extra = TextBox5.Text;
            int F_Profe = Convert.ToInt32(TextBox6.Text);

            op.AgregaPosProf(FechaConfirmado, Comprobacion, Antecedentes, Riesgo, NumContaio, Extra, F_Profe);
            Response.Write("<script>alert('Profesor con covid registrado exitosamente');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox2.Text) && String.IsNullOrEmpty(TextBox3.Text)
                && String.IsNullOrEmpty(TextBox4.Text) && String.IsNullOrEmpty(TextBox5.Text))
            {
                string FechaConfirmado = TextBox1.Text;
                int F_Profe = Convert.ToInt32(TextBox6.Text);
                op.EliminaProPos(FechaConfirmado, F_Profe);
                Response.Write("<script>alert('Profesor positivo eliminado exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Solo escribe la FECHA y el PROFE');</script>");
            }
        }
    }
}