using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class AlContXGrupo : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Selecciona el grado Educativo");
                DropDownList1.Items.Add("1");
                DropDownList1.Items.Add("2");
                DropDownList1.Items.Add("3");
                DropDownList1.Items.Add("4");
                DropDownList1.Items.Add("5");
                DropDownList1.Items.Add("6");
                DropDownList1.Items.Add("7");
                DropDownList1.Items.Add("8");
                DropDownList1.Items.Add("9");
                DropDownList1.Items.Add("10");
                DropDownList1.Items.Add("11");

                DropDownList2.Items.Add("Selecciona el programa Educativo");
                DropDownList2.Items.Add("TSU");
                DropDownList2.Items.Add("Ingeniería");

                DropDownList3.Items.Add("Seleccione la carrera");
                DropDownList3.Items.Add("TI");
                DropDownList3.Items.Add("Meca");
                DropDownList3.Items.Add("Gastro");
                DropDownList3.Items.Add("Ene Renov");
                DropDownList3.Items.Add("Industrial");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Grado = int.Parse(DropDownList1.SelectedValue);
            string Grupo = TextBox1.Text;
            string ProgramaEducativo = DropDownList2.SelectedValue;
            string Carrera = DropDownList3.SelectedValue;
            GridView1.DataSource = op.ConsultaalContgrupo(Grado, Grupo, ProgramaEducativo, Carrera);
            GridView1.DataBind();
        }
    }
}