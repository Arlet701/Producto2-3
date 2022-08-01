using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarPosProfe : System.Web.UI.Page
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
            //Se obtiene el nombre del archivo 
            string Comprobacion2 = FileUpload1.FileName;
            //Definimos la ruta del archivo
            string imgRuta = "PruebaCovid/" + Comprobacion2;
            int imgtamano = FileUpload1.PostedFile.ContentLength;
            if (imgtamano >= 5242880)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert1", "alert('El archivo es muy grande", true);
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath(imgRuta));//Guarda el archivo 
                                                            //Para comprobar que se subio el archivo, se visualiza 
                ImageButton1.ImageUrl = "~/" + imgRuta;//Image1
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert1", "alert('Se guardo el archivo", true);
            }
            string Comprobacion = ImageButton1.ImageUrl;
            string Riesgo = DropDownList1.SelectedValue;
            int NumContaio = Convert.ToInt32(TextBox4.Text);
            string Extra = TextBox5.Text;
            int F_Profe = Convert.ToInt32(TextBox6.Text);

            op.ModificaPosProf(FechaConfirmado, Antecedentes, Comprobacion, Riesgo, NumContaio, Extra, F_Profe);
            Response.Write("<script>alert('Profesor con covid actualizado exitosamente');</script>");
        }

        
    }
}