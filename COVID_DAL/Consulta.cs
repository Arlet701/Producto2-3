using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Servidor SQL
using System.Configuration; //Alcanzar los archivos config
using System.Data;

namespace COVID_DAL
{
    public class Consulta
    {
        //SqlConnection Conexion;
        private string CadCon;

        public Consulta()
        {
            CadCon = ConfigurationManager.ConnectionStrings["segcovid"].ConnectionString;
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

        public DataTable ConsultaAlumno()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Alumno";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

        public DataTable ConsultaProfesor()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Profesor";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

        public DataTable ConsultaCuatri()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Cuatrimestre";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

        public DataTable ConsultaGrupoCuatri()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM GrupoCuatrimestre";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

        public DataTable ConsultaAlGru()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM AlumnoGrupo";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

        public DataTable ConsultaProGru()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM ProfeGRupo";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }
        public DataTable ConsultaPosProf()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM PositivoProfe";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }
        public DataTable ConsultaPosAl()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM PositivoAlumno";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }
        public DataTable ConsultaSegPro()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM SeguimientoPRO";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }
        public DataTable ConsultaSegAl()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM SeguimientoAL";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }
        public DataTable ConsultaMedico()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {

                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Medico";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }

            }
            return (Tabla);
        }

    }

}
