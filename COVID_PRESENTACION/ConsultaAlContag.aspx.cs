﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ConsultaAlContag : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona el programa Educativo");
                DropDownList1.Items.Add("TSU");
                DropDownList1.Items.Add("Ingeniería");

                DropDownList2.Items.Add("Selecciona el Periodo");
                DropDownList2.Items.Add("Enero - Abril");
                DropDownList2.Items.Add("Mayo - Agosto");
                DropDownList2.Items.Add("Septiembre - Diciembre");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ProgramaEducativo = DropDownList1.SelectedValue;
            string Periodo = DropDownList2.SelectedValue;
            int Anio = Convert.ToInt32(TextBox1.Text);
            GridView1.DataSource = op.ConsultaalCont(ProgramaEducativo, Periodo, Anio);
            GridView1.DataBind();
        }
    }
}