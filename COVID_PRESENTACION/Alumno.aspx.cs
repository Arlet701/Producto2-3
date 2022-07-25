using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class Alumno : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string Matricula = TextBox1.Text;
            string Nombre = TextBox2.Text;
            string Ap_pat = TextBox3.Text;
            string Ap_mat = TextBox4.Text;
            string Genero = TextBox5.Text;
            string Correo = TextBox6.Text;
            string Celular = TextBox7.Text;
            int F_EdoCivil = Convert.ToInt32(TextBox9.Text);

            op.AgregaAl(Matricula, Nombre, Ap_pat, Ap_mat, Genero, Correo, Celular, F_EdoCivil);
            Response.Write("<script>alert('Alumno registrado exitosamente');</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox2.Text) && String.IsNullOrEmpty(TextBox3.Text) && String.IsNullOrEmpty(TextBox4.Text) && 
                String.IsNullOrEmpty(TextBox5.Text) && String.IsNullOrEmpty(TextBox6.Text) && String.IsNullOrEmpty(TextBox7.Text))
            {
                string Matricula = TextBox1.Text;
                op.EliminaAlumno(Matricula);
                Response.Write("<script>alert('Alumno eliminado exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>alert('Solo escribe la MATRICULA');</script>");
            }       
        }
    }
}