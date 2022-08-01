﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarPosAlumno : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Selecciona para actualizar");
            DropDownList1.Items.Add("Muy Alto");
            DropDownList1.Items.Add("Alto");
            DropDownList1.Items.Add("Medio");
            DropDownList1.Items.Add("Bajo");
            DropDownList1.Items.Add("Muy Bajo");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string FechaConfirmado = TextBox1.Text;
            string Antecedentes = TextBox2.Text;
            string Comprobacion = TextBox3.Text;
            string Riesgo = DropDownList1.SelectedValue;
            int NumContagio = Convert.ToInt32(TextBox4.Text);
            string Extra = TextBox5.Text;
            int F_Alumno = Convert.ToInt32(TextBox6.Text);

            op.ModificarPosAl(FechaConfirmado, Antecedentes, Comprobacion, Riesgo, NumContagio, Extra, F_Alumno);
            Response.Write("<script>alert('Alumno con covid actualizado exitosamente');</script>");
        }
    }
}