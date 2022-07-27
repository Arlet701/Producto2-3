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
    public class Modificar
    {
        private string CadCon;
        public Modificar()
        {
            CadCon = ConfigurationManager.ConnectionStrings["segcovid"].ConnectionString;
        }
        public void ModificarAlum(string Matricula, string Nombre, string Ap_pat, string Ap_mat, string Genero, string Correo, string Celular, int F_EdoCivil)
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
                    Comando.CommandText = "update Alumno set Nombre=@Nom, Ap_pat =@App,Ap_mat =@Apm, Genero = @Gener, Correo =@Correo,Celular =@Celular,F_EdoCivil =@F_EdoCivil WHERE Matricula = @Mat";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarPro(int Reg, string Nombre, string Ap_pat, string Ap_Mat, string Genero, string Categoria, string Correo, string Celular, int F_EdoCivil)
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
                    Comando.Parameters.AddWithValue("@Cat", Categoria);
                    Comando.Parameters.AddWithValue("@Correo", Correo);
                    Comando.Parameters.AddWithValue("@Celular", Celular);
                    Comando.Parameters.AddWithValue("@F_EdoCivil", F_EdoCivil);
                    Comando.CommandText = "update Profesor SET Nombre=@Nom, Ap_pat = @App, Ap_Mat = @Apm, " +
                        "Genero = @Gener, Categoria = @Cat, Correo = @Correo,Celular = @Celular, F_EdoCivil = @F_EdoCivil " +
                        "WHERE RegistroEmpleado = @Reg";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarCua(string Periodo, int Anio, string Inicio, string Fin, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Per", Periodo);
                    Comando.Parameters.AddWithValue("@Anio", Anio);
                    Comando.Parameters.AddWithValue("@ini", Inicio);
                    Comando.Parameters.AddWithValue("@fin", Fin);
                    Comando.Parameters.AddWithValue("@extra", Extra);
                    Comando.CommandText = "update Cuatrimestre SET Periodo = @Per, Anio = @Anio, Inicio = @ini, " +
                        "Fin = @fin, Extra = @extra WHERE Periodo = @Per AND Anio=@Anio";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarMedico(string correo, string Nombre, string App, string Apm, string telefono, string horario, string especialidad, string extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Corre", correo);
                    Comando.Parameters.AddWithValue("@Nombre", Nombre);
                    Comando.Parameters.AddWithValue("@App", App);
                    Comando.Parameters.AddWithValue("@Apm", Apm);
                    Comando.Parameters.AddWithValue("@tel", telefono);
                    Comando.Parameters.AddWithValue("@hor", horario);
                    Comando.Parameters.AddWithValue("@esp", especialidad);
                    Comando.Parameters.AddWithValue("@Ex", extra);

                    Comando.CommandText = "update Medico SET Nombre=@Nombre, App = @App, Apm = @Apm, Telefono = @tel, " +
                        "horario = @hor, especialidad = @esp, extra = @Ex where correo = @Corre";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarIncapac(string Periodo, string Comprobacion, string Extra, int F_positivoProfe)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Per", Periodo);
                    Comando.Parameters.AddWithValue("@Compr", Comprobacion);
                    Comando.Parameters.AddWithValue("@Extr", Extra);
                    Comando.Parameters.AddWithValue("@F_PosPr", F_positivoProfe);

                    Comando.CommandText = "update Incapacidad SET Periodo=@Per, Comprobacion =@Compr, " +
                        "Extra = @Extr, F_positivoProfe = @F_PosPr WHERE Periodo = @Per";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarPosProfe(string FechaConfirmado, string Antecedentes, string Comprobacion, string Riesgo, int NumContaio, string Extra, int F_Profe)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Fecha", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@Ant", Antecedentes);
                    Comando.Parameters.AddWithValue("@Com", Comprobacion);
                    Comando.Parameters.AddWithValue("@Ries", Riesgo);
                    Comando.Parameters.AddWithValue("@NCont", NumContaio);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.Parameters.AddWithValue("@F_Prof", F_Profe);

                    Comando.CommandText = "update PositivoProfe SET FechaConfirmado=@Fecha, Antecedentes = @Ant, Comprobacion = @Com,  Riesgo = @Ries, " +
                        "NumContaio = @NCont, Extra = @Ex, F_Profe = @F_Prof WHERE FechaConfirmado = @Fecha AND Antecedentes = @Ant";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarPosAlum(string FechaConfirmado, string Antecedentes, string Comprobacion, string Riesgo, int NumContagio, string Extra, int F_Alumno)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@Fecha", FechaConfirmado);
                    Comando.Parameters.AddWithValue("@Ant", Antecedentes);
                    Comando.Parameters.AddWithValue("@Com", Comprobacion);
                    Comando.Parameters.AddWithValue("@Ries", Riesgo);
                    Comando.Parameters.AddWithValue("@NCont", NumContagio);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.Parameters.AddWithValue("@F_Alum", F_Alumno);

                    Comando.CommandText = "update PositivoAlumno SET FechaConfirmado=@Fecha, Antecedentes = @Ant, Comprobacion = @Com,  Riesgo = @Ries, " +
                        "NumContagio = @NCont, Extra = @Ex, F_Alumno = @F_Alum WHERE FechaConfirmado = @Fecha AND Antecedentes = @Ant";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarGruCua(int Id_GruCuat,int F_ProgEd, int F_Grupo, int F_Cuatri, string Turno, string Modalidad, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@id", Id_GruCuat);
                    Comando.Parameters.AddWithValue("@Proged", F_ProgEd);
                    Comando.Parameters.AddWithValue("@F_Gru", F_Grupo);
                    Comando.Parameters.AddWithValue("@F_Cuat", F_Cuatri);
                    Comando.Parameters.AddWithValue("@Tur", Turno);
                    Comando.Parameters.AddWithValue("@Modal", Modalidad);
                    Comando.Parameters.AddWithValue("@Ex", Extra);
                    Comando.CommandText = "update GrupoCuatrimestre SET F_ProgEd=@Proged, F_Grupo = @F_Gru, F_Cuatri = @F_Cuat, Turno = @Tur, " +
                        "Modalidad = @Modal, Extra = @Ex where Id_GruCuat = @id";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarAlGru(int ID_AlumnGru, int F_Alumno, int F_GruCuat, string Extra, string Extra2)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@ID",ID_AlumnGru);
                    Comando.Parameters.AddWithValue("@F_al", F_Alumno);
                    Comando.Parameters.AddWithValue("@F_GruCu", F_GruCuat);
                    Comando.Parameters.AddWithValue("@Ex1", Extra);
                    Comando.Parameters.AddWithValue("@Ex2", Extra2);
                    Comando.CommandText = "update AlumnoGrupo SET F_Alumn=@F_al, F_GruCuat = @F_GruCu, Extra = @Ex1, " +
                        "Extra2 = @Ex2 where ID_AlumnGru = @ID";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarProfGru(int ID_ProfeGru, int F_Profe, int F_GruCuat, string Extra, string Extra2)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("IdProf",ID_ProfeGru);
                    Comando.Parameters.AddWithValue("@F_prof", F_Profe);
                    Comando.Parameters.AddWithValue("@F_GruCu", F_GruCuat);
                    Comando.Parameters.AddWithValue("@Ex1", Extra);
                    Comando.Parameters.AddWithValue("@Ex2", Extra2);
                    Comando.CommandText = "update ProfeGRupo SET F_Profe=@F_prof, F_GruCuat = @F_GruCu,Extra = @Ex1, Extra2=@Ex2 where ID_ProfeGru = @IdProf";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
        public void ModificarSegProf(int id_Segui, int F_positivoProfe, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@id", id_Segui);
                    Comando.Parameters.AddWithValue("@F_pos_Profe", F_positivoProfe);
                    Comando.Parameters.AddWithValue("@F_med", F_medico);
                    Comando.Parameters.AddWithValue("@Fecha", Fecha);
                    Comando.Parameters.AddWithValue("@Com", Form_Comunica);
                    Comando.Parameters.AddWithValue("@Rep", Reporte);
                    Comando.Parameters.AddWithValue("@Ent", Entrevista);
                    Comando.Parameters.AddWithValue("@Ex", Extra);

                    Comando.CommandText = "update SeguimientoPRO SET F_positivoProfe=@F_pos_Profe, F_medico = @F_med, Fecha = @Fecha, Form_Comunica = @Com, Reporte = @Rep, " +
                        "Entrevista = @Ent, Extra = @Ex where id_Segui = @id";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }

        public void ModificarSegALUM(int Id_Seguimiento, int F_positivoAL, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Comando = new SqlCommand())
                {
                    Comando.Connection = Con;
                    Comando.Parameters.AddWithValue("@ID", Id_Seguimiento);
                    Comando.Parameters.AddWithValue("@F_pos_AL", F_positivoAL);
                    Comando.Parameters.AddWithValue("@F_med", F_medico);
                    Comando.Parameters.AddWithValue("@Fecha", Fecha);
                    Comando.Parameters.AddWithValue("@Com", Form_Comunica);
                    Comando.Parameters.AddWithValue("@Rep", Reporte);
                    Comando.Parameters.AddWithValue("@Ent", Entrevista);
                    Comando.Parameters.AddWithValue("@Ex", Extra);

                    Comando.CommandText = "update SeguimientoAL SET F_PositivoAL=@F_pos_AL, F_medico = @F_med, Fecha = @Fecha, Form_Comunica = @Com, " +
                        "Reporte = @Rep, Entrevista = @Ent, Extra = @Ex where Id_Seguimiento = @ID";
                    Comando.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
        }
    }
}
