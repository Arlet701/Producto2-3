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
    public class Insertar
    {
        //SqlConnection Conexion;
        private string CadCon;

        public Insertar()
        {
            CadCon = ConfigurationManager.ConnectionStrings["segcovid"].ConnectionString;

        }

        public void AgregarAl(string Matricula, string Nombre, string Ap_pat, string Ap_mat, string Genero, string Correo, string Celular, int F_EdoCivil)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Mat", Matricula);
                    Comando.Parameters.AddWithValue("@Nom", Nombre);
                    Comando.Parameters.AddWithValue("@App", Ap_pat);
                    Comando.Parameters.AddWithValue("@Apm", Ap_mat);
                    Comando.Parameters.AddWithValue("@Gener", Genero);
                    Comando.Parameters.AddWithValue("@Correo", Correo);
                    Comando.Parameters.AddWithValue("@Celular", Celular);
                    Comando.Parameters.AddWithValue("@F_EdoCivil", F_EdoCivil);
                    Comando.CommandText = "Insert Into Alumno VALUES (@Mat, @Nom, @App, @Apm, @Gener, @Correo, @Celular, @F_EdoCivil)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void AgregarPro(int Reg, string Nombre, string Ap_pat, string Ap_Mat, string Genero, string Cat, string Correo, string Celular, int F_EdoCivil)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Reg", Reg);
                    Comando.Parameters.AddWithValue("@Nom", Nombre);
                    Comando.Parameters.AddWithValue("@App", Ap_pat);
                    Comando.Parameters.AddWithValue("@Apm", Ap_Mat);
                    Comando.Parameters.AddWithValue("@Gener", Genero);
                    Comando.Parameters.AddWithValue("@Cat", Cat);
                    Comando.Parameters.AddWithValue("@Correo", Correo);
                    Comando.Parameters.AddWithValue("@Celular", Celular);
                    Comando.Parameters.AddWithValue("@F_EdoCivil", F_EdoCivil);
                    Comando.CommandText = "INSERT INTO Profesor VALUES (@Reg, @Nom, @App, @Apm, @Gener, @Cat, @Correo, @Celular, @F_EdoCivil)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void AgregarCua(string Periodo, int anio, string inicio, string Fin, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Per", Periodo);
                    Comando.Parameters.AddWithValue("@Anio", anio);
                    Comando.Parameters.AddWithValue("@ini", inicio);
                    Comando.Parameters.AddWithValue("@fin", Fin);
                    Comando.Parameters.AddWithValue("@extra", Extra);
                    Comando.CommandText = "INSERT INTO Cuatrimestre Values (@Per, @Anio,@ini,@fin, @extra)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregarGruCua(int F_ProgEd, int F_Grupo, int F_Cuatri, string Turno, string Modalidad, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Proged", F_ProgEd);
                    Comando.Parameters.AddWithValue("@F_Gru", F_Grupo);
                    Comando.Parameters.AddWithValue("@F_Cuat", F_Cuatri);
                    Comando.Parameters.AddWithValue("@Tur", Turno);
                    Comando.Parameters.AddWithValue("@Modal", Modalidad);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.CommandText = "INSERT INTO GrupoCuatrimestre VALUES (@Proged, @F_Gru, @F_Cuat, @Tur, @Modal, @Ex)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregarAlGru(int F_Alumno, int F_GruCuat, string Extra, string Extra2)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_al", F_Alumno);
                    Comando.Parameters.AddWithValue("@F_GruCu", F_GruCuat);
                    Comando.Parameters.AddWithValue("@Ex1", Extra);
                    Comando.Parameters.AddWithValue("@Ex2", Extra2);
                    Comando.CommandText = "INSERT INTO AlumnoGrupo VALUES (@F_al, @F_GruCu, @Ex1, @Ex2)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregarProfGru(int F_Profe, int F_GruCuat, string Extra, string Extra2)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_prof", F_Profe);
                    Comando.Parameters.AddWithValue("@F_GruCu", F_GruCuat);
                    Comando.Parameters.AddWithValue("@Ex1", Extra);
                    Comando.Parameters.AddWithValue("@Ex2", Extra2);
                    Comando.CommandText = "INSERT INTO ProfeGRupo VALUES (@F_prof, @F_GruCu, @Ex1, @Ex2)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void AgregarPosProfe(string FechaConfirmado, string Comprobacion, string Antecedentes, string Riesgo, int NumContaio, string Extra, int F_Profe)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Fecha", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@Com", Comprobacion);
                    Comando.Parameters.AddWithValue("@Ant", Antecedentes);
                    Comando.Parameters.AddWithValue("@Ries", Riesgo);
                    Comando.Parameters.AddWithValue("@NCont", NumContaio);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.Parameters.AddWithValue("@F_Prof", F_Profe);

                    Comando.CommandText = "INSERT INTO PositivoProfe VALUES (@Fecha, @Com, @Ant, @Ries, @NCont, @Ex, @F_Prof)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void AgregarPosAlum(string FechaConfirmado, string Comprobacion, string Antecedentes, string Riesgo, int NumContagio, string Extra, int F_Alumno)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Fecha", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@Com", Comprobacion);
                    Comando.Parameters.AddWithValue("@Ant", Antecedentes);
                    Comando.Parameters.AddWithValue("@Ries", Riesgo);
                    Comando.Parameters.AddWithValue("@NCont", NumContagio);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.Parameters.AddWithValue("@F_Alum", F_Alumno);

                    Comando.CommandText = "INSERT INTO PositivoAlumno VALUES (@Fecha, @Com, @Ant, @Ries, @NCont, @Ex, @F_Alum)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregaSegPro(int F_positivoProfe, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_pos_Profe", F_positivoProfe);
                    Comando.Parameters.AddWithValue("@F_med", F_medico);
                    Comando.Parameters.AddWithValue("@Fecha", Fecha);
                    Comando.Parameters.AddWithValue("@Com", Form_Comunica);
                    Comando.Parameters.AddWithValue("@Rep", Reporte);
                    Comando.Parameters.AddWithValue("@Ent", Entrevista);
                    Comando.Parameters.AddWithValue("@Ex", Extra);

                    Comando.CommandText = "INSERT INTO SeguimientoPRO VALUES (@F_pos_Profe, @F_med, @Fecha,@Com, @Rep,@Ent,@Ex)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void AgregaSegAL(int F_positivoAL, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@F_pos_AL", F_positivoAL);
                    Comando.Parameters.AddWithValue("@F_med", F_medico);
                    Comando.Parameters.AddWithValue("@Fecha", Fecha);
                    Comando.Parameters.AddWithValue("@Com", Form_Comunica);
                    Comando.Parameters.AddWithValue("@Rep", Reporte);
                    Comando.Parameters.AddWithValue("@Ent", Entrevista);
                    Comando.Parameters.AddWithValue("@Ex", Extra);

                    Comando.CommandText = "INSERT INTO SeguimientoAL VALUES (@F_pos_AL, @F_med, @Fecha,@Com, @Rep,@Ent,@Ex)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregaMedico(string Nombre, string App, string Apm, string telefono, string correo, string horario, string especialidad, string extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Nombre", Nombre);
                    Comando.Parameters.AddWithValue("@App", App);
                    Comando.Parameters.AddWithValue("@Apm", Apm);
                    Comando.Parameters.AddWithValue("@tel", telefono);
                    Comando.Parameters.AddWithValue("Corre", correo);
                    Comando.Parameters.AddWithValue("@hor", horario);
                    Comando.Parameters.AddWithValue("@esp", especialidad);
                    Comando.Parameters.AddWithValue("@Ex", extra);

                    Comando.CommandText = "INSERT INTO Medico VALUES(@Nombre,@App, @Apm, @tel, @Corre, @hor, @esp, @Ex)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void AgregarIncapac (string Periodo, string Comprobacion, string Extra, int F_positivoProfe)
        {
            using (SqlConnection Con= new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Per", Periodo);
                    Comando.Parameters.AddWithValue("@Compr", Comprobacion);
                    Comando.Parameters.AddWithValue("@Extr", Extra);
                    Comando.Parameters.AddWithValue("@F_PosPr", F_positivoProfe);

                    Comando.CommandText = "INSERT INTO Incapacidad VALUES (@Per, @Compr, @Extr, @F_PosPr)";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

    }
}
