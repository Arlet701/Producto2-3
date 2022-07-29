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
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM EstadoCivil";
                    SqlDataAdapter Da = new SqlDataAdapter ();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
            return (Tabla);
            
        }

        public DataTable ConsultaAlumno()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();
            
            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Alumno";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }

        public DataTable ConsultaProfesor()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Profesor";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
            return (Tabla);
        }

        public DataTable ConsultaCuatri()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Cuatrimestre";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }

        public DataTable ConsultaGrupoCuatri()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM GrupoCuatrimestre";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }

        public DataTable ConsultaAlGru()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM AlumnoGrupo";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }

        public DataTable ConsultaProGru()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM ProfeGRupo";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }
        public DataTable ConsultaPosProf()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM PositivoProfe";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }
        public DataTable ConsultaPosAl()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM PositivoAlumno";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }
        public DataTable ConsultaSegPro()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM SeguimientoPRO";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();

            }
            return (Tabla);
        }
        public DataTable ConsultaSegAl()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM SeguimientoAL";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
            return (Tabla);
        }
        public DataTable ConsultaMedico()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Medico";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
            return (Tabla);
        }

        public DataTable ConsultaIncapacidad()
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.CommandText = "SELECT*FROM Incapacidad";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                    Com.ExecuteNonQuery();
                }
                Con.Close();
                Con.Dispose();
            }
            return (Tabla);
        }
        public DataTable ConsultaProfesorContagiado(string ProgramaEducativo, string Periodo, int Anio, string Carrera)
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.Parameters.AddWithValue("@Prog", ProgramaEducativo);
                    Com.Parameters.AddWithValue("@Per", Periodo);
                    Com.Parameters.AddWithValue("@Anio", Anio);
                    Com.Parameters.AddWithValue("@Carr", Carrera);
                    Com.CommandText = "select DISTINCT Profesor.Nombre, Profesor.Ap_pat, Profesor.Ap_Mat,ProgramaEducativo.ProgramaEd from Profesor " +
                        " INNER JOIN PositivoProfe ON PositivoProfe.F_Profe = Profesor.ID_Profe " +
                        " INNER JOIN ProfeGRupo ON ProfeGRupo.F_Profe = PositivoProfe.F_Profe " +
                        " INNER JOIN GrupoCuatrimestre ON GrupoCuatrimestre.Id_GruCuat = ProfeGRupo.F_GruCuat " +
                        " INNER JOIN ProgramaEducativo ON ProgramaEducativo.Id_pe = GrupoCuatrimestre.F_ProgEd " +
                        " INNER JOIN Carrera ON Carrera.Id_Carrera = ProgramaEducativo.F_Carrera " +
                        " INNER JOIN Cuatrimestre ON Cuatrimestre.id_Cuatrimestre = GrupoCuatrimestre.F_Cuatri " +
                        " where ProgramaEducativo.ProgramaEd = @Prog and Cuatrimestre.Periodo = @Per and Cuatrimestre.Anio = @Anio AND Carrera.nombreCarrera = @Carr";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }
            }
            return (Tabla);
        }
        public DataTable ConsultaALContagiado(string ProgramaEducativo, string Periodo, int Anio, string Carrera)
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.Parameters.AddWithValue("@Prog", ProgramaEducativo);
                    Com.Parameters.AddWithValue("@Per", Periodo);
                    Com.Parameters.AddWithValue("@Anio", Anio);
                    Com.Parameters.AddWithValue("@Carr", Carrera);
                    Com.CommandText = "select DISTINCT Alumno.Nombre, Alumno.Ap_pat, Alumno.Ap_mat from Alumno " +
                        " INNER JOIN PositivoAlumno ON PositivoAlumno.F_Alumno = Alumno.ID_Alumno " +
                        " INNER JOIN AlumnoGrupo ON AlumnoGrupo.F_Alumn = PositivoAlumno.F_Alumno " +
                        " INNER JOIN GrupoCuatrimestre ON GrupoCuatrimestre.Id_GruCuat = AlumnoGrupo.F_GruCuat " +
                        " INNER JOIN ProgramaEducativo ON ProgramaEducativo.Id_pe = GrupoCuatrimestre.F_ProgEd " +
                        " INNER JOIN Carrera ON Carrera.Id_Carrera = ProgramaEducativo.F_Carrera " +
                        " INNER JOIN Cuatrimestre ON Cuatrimestre.id_Cuatrimestre = GrupoCuatrimestre.F_Cuatri where ProgramaEducativo.ProgramaEd = @Prog " +
                        " and Cuatrimestre.Periodo = @Per and Cuatrimestre.Anio = @Anio AND Carrera.nombreCarrera = @Carr";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }
            }
            return (Tabla);
        }
        public DataTable ConsultaALContagiadoPorGrupo(int Grado, string Grupo, string ProgramaEducativo, string Carrera)
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.Parameters.AddWithValue("@Gra", Grado);
                    Com.Parameters.AddWithValue("@Gru", Grupo);
                    Com.Parameters.AddWithValue("@Prog", ProgramaEducativo);
                    Com.Parameters.AddWithValue("@Carr", Carrera);
                    Com.CommandText = "select DISTINCT Alumno.Nombre, Alumno.Ap_pat, Alumno.Ap_mat from Alumno " +
                        " INNER JOIN PositivoAlumno ON PositivoAlumno.F_Alumno = Alumno.ID_Alumno " +
                        " INNER JOIN AlumnoGrupo ON AlumnoGrupo.F_Alumn = PositivoAlumno.F_Alumno " +
                        " INNER JOIN GrupoCuatrimestre ON GrupoCuatrimestre.Id_GruCuat = AlumnoGrupo.F_GruCuat " +
                        " INNER JOIN Grupo ON Grupo.Id_grupo = GrupoCuatrimestre.F_Grupo " +
                        " INNER JOIN ProgramaEducativo ON ProgramaEducativo.Id_pe = GrupoCuatrimestre.F_ProgEd " +
                        " INNER JOIN Carrera ON Carrera.Id_Carrera = ProgramaEducativo.F_Carrera " +
                        " INNER JOIN Cuatrimestre ON Cuatrimestre.id_Cuatrimestre = GrupoCuatrimestre.F_Cuatri " +
                        " where Grupo.Grado = @Gra AND Grupo.Letra = @Gru AND ProgramaEducativo.ProgramaEd = @Prog AND Carrera.nombreCarrera = @Carr";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }
            }
            return (Tabla);
        }
        public DataTable ConsultaSegALReg(string Periodo, string Matricula)
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.Parameters.AddWithValue("@Per", Periodo);
                    Com.Parameters.AddWithValue("@Mat", Matricula);
                    Com.CommandText = "select Alumno.Matricula, Alumno.Nombre, Alumno.Ap_pat, Alumno.Ap_mat, SeguimientoAL.Fecha, SeguimientoAL.Reporte, " +
                        " SeguimientoAL.Form_Comunica, Cuatrimestre.Periodo from Alumno " +
                        " INNER JOIN PositivoAlumno ON PositivoAlumno.F_Alumno = Alumno.ID_Alumno " +
                        " INNER JOIN SeguimientoAL ON SeguimientoAL.F_PositivoAL = PositivoAlumno.ID_posAl " +
                        " INNER JOIN AlumnoGrupo ON AlumnoGrupo.F_Alumn = PositivoAlumno.F_Alumno" +
                        " INNER JOIN GrupoCuatrimestre ON GrupoCuatrimestre.Id_GruCuat = AlumnoGrupo.F_GruCuat " +
                        " INNER JOIN Cuatrimestre ON Cuatrimestre.id_Cuatrimestre = GrupoCuatrimestre.F_Cuatri " +
                        " where Cuatrimestre.Periodo = @Per  AND Alumno.Matricula = @Mat";
                    SqlDataAdapter Da = new SqlDataAdapter();
                    Da.SelectCommand = Com;
                    Da.Fill(Cont);
                    Tabla = Cont.Tables[0];
                }
            }
            return (Tabla);
        }
        public DataTable ConsultaContProf(string Nombre, string Ap_pat, string Ap_Mat)
        {
            DataTable Tabla = null;
            DataSet Cont = new DataSet();

            using (SqlConnection Con = new SqlConnection(CadCon))
            {
                using (SqlCommand Com = new SqlCommand())
                {
                    Com.Connection = Con;
                    Com.Parameters.AddWithValue("@Nom", Nombre);
                    Com.Parameters.AddWithValue("@App", Ap_pat);
                    Com.Parameters.AddWithValue("@Apm", Ap_Mat);
                    Com.CommandText = "select Profesor.Nombre AS Nombre,Profesor.Ap_pat AS ApellidoPaterno,Profesor.Ap_Mat AS " +
                        " ApellidoMaterno,PositivoProfe.NumContaio AS NúmeroContagio, PositivoProfe.Antecedentes AS Antecedentes, " +
                        " PositivoProfe.Riesgo AS Riesgo, SeguimientoPRO.Fecha AS Fecha,SeguimientoPRO.Reporte AS Reporte, " +
                        " Incapacidad.Comprobacion AS Comprobante,Incapacidad.Periodo AS Periodo from Profesor " +
                        " INNER JOIN PositivoProfe ON Profesor.ID_Profe = PositivoProfe.F_Profe " +
                        " INNER JOIN SeguimientoPRO ON PositivoProfe.Id_posProfe = SeguimientoPRO.F_positivoProfe " +
                        " INNER JOIN Incapacidad ON Incapacidad.id_Incapacidad = PositivoProfe.Id_posProfe " +
                        " WHERE Profesor.Nombre = @Nom AND Profesor.Ap_pat = @App AND Profesor.Ap_Mat = @Apm";
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
