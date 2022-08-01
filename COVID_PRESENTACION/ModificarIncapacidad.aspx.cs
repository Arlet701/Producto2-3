using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COVID_BL;

namespace COVID_PRESENTACION
{
    public partial class ModificarIncapacidad : System.Web.UI.Page
    {
        covid_bl op = new covid_bl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Periodo = TextBox1.Text;
            string Comprobacion2 = FileUpload1.FileName;
            //Definimos la ruta del archivo
            string imgRuta = "ComprobanteIncapacidad/" + Comprobacion2;
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
            string Extra = TextBox3.Text;
            int F_positivoProfe = Convert.ToInt32(TextBox4.Text);

            op.ModificarIncap(Periodo, Comprobacion, Extra, F_positivoProfe);
            Response.Write("<script>alert('Tipo de incapacidad actualizado exitosamente');</script>");
        }
    }
}