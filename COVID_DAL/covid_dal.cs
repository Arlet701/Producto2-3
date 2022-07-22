using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Servidor SQL
using System.Configuration; //Alcanzar los archivos config
using COVID_DAL.Models; //Tomar los valores. 
using System.Data;

namespace COVID_DAL
{
    public class covid_dal
    {
        SqlConnection Conexion;
        private string CadCon;

        public covid_dal()
        {
            CadCon = ConfigurationManager.ConnectionStrings["segcovid"].ConnectionString;
        }
        public string RevisarCon()
        {
            try
            {
                Conexion = new SqlConnection(CadCon);
                Conexion.Open();
                Conexion.Close();
            }
            catch (Exception e)
            {
                return "Algo salió mal : " + e.Message;

            }
            return "La conexión se estableció";

        }
        public DataTable ConsultaCivil()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM EstadoCivil";
                    SqlDataAdapter Da = new SqlDataAdapter ();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }


    }

}
