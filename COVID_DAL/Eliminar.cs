using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Servidor SQL
using System.Configuration; //Alcanzar los archivos config
using COVID_DAL.Models; //Alcanzar los valores de los datos. 

namespace COVID_DAL
{
    public class Eliminar
    {
        //SqlConnection Conexion;
        private string CadCon;

        public Eliminar()
        {
            CadCon = ConfigurationManager.ConnectionStrings["segcovid"].ConnectionString;
        }
        public void EliminarAlumno(string Matricula)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Mat", Matricula);
                    Comando.CommandText = "DELETE FROM Alumno Where Matricula = @Mat";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarProf(string Nombre, string Ap_pat)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Nom", Nombre);
                    Comando.Parameters.AddWithValue("@App", Ap_pat);

                    Comando.CommandText = "DELETE FROM Profesor WHERE Nombre = @Nom AND Ap_pat = @App";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarCuat(string Periodo, int Anio)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Per", Periodo);
                    Comando.Parameters.AddWithValue("@Ani", Anio);

                    Comando.CommandText = "DELETE FROM Cuatrimestre WHERE Periodo = @Per AND Anio = @Ani";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarGrpCuat(int ProgEd, int F_Grupo, string Turno)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@PrgEd", ProgEd);
                    Comando.Parameters.AddWithValue("@F_Grp", F_Grupo);
                    Comando.Parameters.AddWithValue("@Tur", Turno);

                    Comando.CommandText = "DELETE FROM GrupoCuatrimestre WHERE F_ProgEd = @PrgEd AND F_Grupo = @F_Grp AND Turno = @Tur";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void EliminarAlGrp(int F_Alumno)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_Al", F_Alumno);

                    Comando.CommandText = "DELETE FROM AlumnoGrupo WHERE F_Alumn = @F_Al";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarProGrp(int F_Profe)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_Pro", F_Profe);

                    Comando.CommandText = "DELETE FROM ProfeGRupo WHERE F_Profe = @F_Pro";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void EliminarProPos(string FechaConfirmado, int F_Profe)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;

                    Comando.Parameters.AddWithValue("@FechaC", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@F_Pro", F_Profe);

                    Comando.CommandText = "DELETE FROM PositivoProfe WHERE FechaConfirmado = @FechaC AND F_Profe = @F_Pro";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarALPos(string FechaConfirmado, int F_Alumno)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;

                    Comando.Parameters.AddWithValue("@FechaC", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@F_AL", F_Alumno);

                    Comando.CommandText = "DELETE FROM PositivoAlumno WHERE FechaConfirmado = @FechaC AND F_Alumno = @F_AL";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void EliminarSegPro(int F_PositivoProfe , string FechaConfirmado)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_Pos", F_PositivoProfe);
                    Comando.Parameters.AddWithValue("@FechaC", FechaConfirmado);
                    

                    Comando.CommandText = "DELETE FROM SeguimientoPRO WHERE F_positivoProfe = @F_Pos AND Fecha = @FechaC";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarSegAL(int F_PositivoAL, string FechaConfirmado)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_Pos", F_PositivoAL);
                    Comando.Parameters.AddWithValue("@FechaC", FechaConfirmado);


                    Comando.CommandText = "DELETE FROM SeguimientoAL WHERE F_PositivoAL = @F_Pos AND Fecha = @FechaC";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarMedico(string Nombre, string App, string Apm)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Nom", Nombre);
                    Comando.Parameters.AddWithValue("@app", App);
                    Comando.Parameters.AddWithValue("@apm", Apm);

                    Comando.CommandText = "DELETE FROM Medico WHERE Nombre = @Nom AND App = @app AND Apm = @apm";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void EliminarIncapac(string Periodo, string Comprobacion)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Perio", Periodo);
                    Comando.Parameters.AddWithValue("@Compr", Comprobacion);

                    Comando.CommandText = "DELETE FROM Incapacidad WHERE Periodo = @Perio AND Comprobacion = @Compr";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }


    }
}
