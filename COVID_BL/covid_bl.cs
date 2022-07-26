using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COVID_DAL;
using System.Data;

namespace COVID_BL
{
    public class covid_bl
    {
        Consulta BD = new Consulta();
        Insertar IN = new Insertar();
        Eliminar EL = new Eliminar();

        public DataTable Alum()
        {
            return BD.ConsultaAlumno();
        }
        public DataTable Profe()
        {
            return BD.ConsultaProfesor();
        }
        public DataTable Cuatri()
        {
            return BD.ConsultaCuatri();
        }
        public DataTable GrupoCuatri()
        {
            return BD.ConsultaGrupoCuatri();
        }
        public DataTable AluGru()
        {
            return BD.ConsultaAlGru();
        }
        public DataTable ProfeGru()
        {
            return BD.ConsultaProGru();
        }
        public DataTable Profpos()
        {
            return BD.ConsultaPosProf();
        }
        public DataTable Alpos()
        {
            return BD.ConsultaPosAl();
        }
        public DataTable ProSeg()
        {
            return BD.ConsultaSegPro();
        }
        public DataTable AlSeg()
        {
            return BD.ConsultaSegAl();
        }
        public DataTable Med()
        {
            return BD.ConsultaMedico();
        }
        public DataTable Inc()
        {
            return BD.ConsultaIncapacidad();
        }


        public void AgregaAl(string Matricula, string Nombre, string Ap_pat, string Ap_mat, string Genero, string Correo, string Celular, int F_EdoCivil)
        {
            IN.AgregarAl(Matricula, Nombre, Ap_pat, Ap_mat, Genero, Correo, Celular, F_EdoCivil);
        }
        public void AgregaProf(int Reg, string Nombre, string Ap_pat, string Ap_Mat, string Genero, string Cat, string Correo, string Celular, int F_EdoCivil)
        {
            IN.AgregarPro(Reg, Nombre, Ap_pat, Ap_Mat, Genero, Cat, Correo, Celular, F_EdoCivil);
        }
        public void AgregaCuat(string Periodo, int anio, string inicio, string Fin, string Extra)
        {
            IN.AgregarCua(Periodo, anio, inicio, Fin, Extra);
        }
        public void AgregaGrpCuat(int F_ProgEd, int F_Grupo, int F_Cuatri, string Turno, string Modalidad, string Extra)
        {
            IN.AgregarGruCua(F_ProgEd, F_Grupo, F_Cuatri, Turno, Modalidad, Extra);
        }
        public void AgregaAlGrp(int F_Alumno, int F_GruCuat, string Extra, string Extra2)
        {
            IN.AgregarAlGru(F_Alumno, F_GruCuat, Extra, Extra2);
        }
        public void AgregaProfGrp (int F_Profe, int F_GruCuat, string Extra, string Extra2)
        {
            IN.AgregarProfGru(F_Profe, F_GruCuat, Extra, Extra2);
        }
        public void AgregaPosProf(string FechaConfirmado, string Comprobacion, string Antecedentes, string Riesgo, int NumContaio, string Extra, int F_Profe)
        {
            IN.AgregarPosProfe(FechaConfirmado, Comprobacion,Antecedentes,Riesgo,NumContaio,Extra,F_Profe);
        }
        public void AgregaPosAl(string FechaConfirmado, string Comprobacion, string Antecedentes, string Riesgo, int NumContagio, string Extra, int F_Alumno)
        {
            IN.AgregarPosAlum(FechaConfirmado, Comprobacion, Antecedentes, Riesgo, NumContagio, Extra, F_Alumno);
        }
        public void AgregaSegPro(int F_positivoProfe, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            IN.AgregaSegPro(F_positivoProfe, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
        }
        public void AgregaSegAL(int F_positivoAL, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            IN.AgregaSegAL(F_positivoAL, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
        }
        public void AgregaMed(string Nombre, string App, string Apm, string telefono, string correo, string horario, string especialidad, string extra)
        {
            IN.AgregaMedico(Nombre, App, Apm, telefono, correo, horario, especialidad, extra);
        }
        public void EliminaAlumno(string Matricula)
        {
            EL.EliminarAlumno(Matricula);
        } 
        public void EliminaProfe(string Nombre, string App)
        {
            EL.EliminarProf(Nombre, App);
        }
        public void EliminaCuatri(string Periodo, int Anio)
        {
            EL.EliminarCuat(Periodo, Anio);
        }
        public void EliminaGrpCuat(int ProgEd, int F_Grupo, string Turno)
        {
            EL.EliminarGrpCuat(ProgEd, F_Grupo, Turno);
        }
        public void EliminaAlGrp(int F_Alumno)
        {
            EL.EliminarAlGrp(F_Alumno);
        }
        public void EliminaProGrp(int F_Profe)
        {
            EL.EliminarProGrp(F_Profe);
        }
        public void EliminaProPos(string FechaConfirmado, int F_Profe)
        {
            EL.EliminarProPos(FechaConfirmado, F_Profe);
        }
        public void EliminaALPos(string FechaConfirmado, int F_Alumno)
        {
            EL.EliminarALPos(FechaConfirmado, F_Alumno);
        }
        public void EliminaSegProfe(int F_PositivoProfe, string FechaConfirmado)
        {
            EL.EliminarSegPro(F_PositivoProfe, FechaConfirmado);
        }
        public void EliminaSegAL(int F_PositivoAL, string FechaConfirmado)
        {
            EL.EliminarSegAL(F_PositivoAL, FechaConfirmado);
        }
        public void EliminaMed(string Nombre, string App, string Apm)
        {
            EL.EliminarMedico(Nombre, App, Apm);
        }
    }

}
