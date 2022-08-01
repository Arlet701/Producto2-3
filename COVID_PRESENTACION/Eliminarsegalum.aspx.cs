﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class Eliminarsegalum : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text))
            {

                Response.Write("<script>alert('Solo escribe al ALUMNO y la FECHA');</script>");
            }
            else
            {
                int F_PositivoAL = Convert.ToInt32(TextBox1.Text);
                string FechaConfirmado = TextBox2.Text;
                op.EliminaSegAL(F_PositivoAL, FechaConfirmado);
                Response.Write("<script>alert('Seguimiento Alumno eliminado exitosamente');</script>");
            }
        }
    }
}