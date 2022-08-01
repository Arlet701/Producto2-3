﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class Profesor : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Seleccione la categoría");
                DropDownList1.Items.Add("PTA");
                DropDownList1.Items.Add("PTC");

                DropDownList2.Items.Add("Seleccione el genero");
                DropDownList2.Items.Add("Hombre");
                DropDownList2.Items.Add("Mujer");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Reg= Convert.ToInt32(TextBox1.Text);
            string Nombre = TextBox2.Text;
            string Ap_pat = TextBox3.Text;
            string Ap_Mat = TextBox4.Text;
            string Genero = DropDownList2.SelectedValue;
            string Cat = DropDownList1.SelectedValue;
            string Correo = TextBox6.Text;
            string Celular = TextBox7.Text;
            int F_EdoCivil = Convert.ToInt32(TextBox9.Text);

            op.AgregaProf(Reg, Nombre, Ap_pat, Ap_Mat, Genero, Cat, Correo, Celular, F_EdoCivil);
            Response.Write("<script>alert('Profesor registrado exitosamente');</script>");
        }

    } 
}