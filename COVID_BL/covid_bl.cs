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
        Modificar MOD = new Modificar();

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

        public DataTable ConsultaProfCont(string ProgramaEducativo, string Periodo, int Anio, string Carrera)
        {
            return BD.ConsultaProfesorContagiado(ProgramaEducativo, Periodo, Anio, Carrera);
        }
        public DataTable ConsultaalCont(string ProgramaEducativo, string Periodo, int Anio, string Carrera)
        {
            return BD.ConsultaALContagiado(ProgramaEducativo, Periodo, Anio, Carrera);
        }
        public DataTable ConsultaalContgrupo(int Grado, string Grupo, string ProgramaEducativo, string Carrera)
        {
            return BD.ConsultaALContagiadoPorGrupo(Grado, Grupo, ProgramaEducativo, Carrera);
        }
        public DataTable ConsultaSegAL(string Periodo, string Matricula)
        {
            return BD.ConsultaSegALReg(Periodo, Matricula);
        }
        public DataTable ConsultaContPro(string Nombre, string Ap_pat, string Ap_Mat)
        {
            return BD.ConsultaContProf(Nombre, Ap_pat, Ap_Mat);
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
        public void AgregarIncap(string Periodo, string Comprobacion, string Extra, int F_positivoProfe)
        {
            IN.AgregarIncapac(Periodo, Comprobacion, Extra, F_positivoProfe);
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
        public void EliminarIncap(string Periodo, int F_positivoProfe)
        {
            EL.EliminarIncapac(Periodo, F_positivoProfe);
        }
        public void ModificarAl(string Matricula, string Nombre, string Ap_pat, string Ap_mat, string Genero, string Correo, string Celular, int F_EdoCivil)
        {
            MOD.ModificarAlum(Matricula, Nombre, Ap_pat, Ap_mat, Genero, Correo, Celular, F_EdoCivil);
        }
        public void ModificarProf(int Reg, string Nombre, string Ap_pat, string Ap_Mat, string Genero, string Categoria, string Correo, string Celular, int F_EdoCivil)
        {
            MOD.ModificarPro(Reg, Nombre, Ap_pat, Ap_Mat, Genero, Categoria, Correo, Celular, F_EdoCivil);
        }
        public void ModificarCuat(string Periodo, int Anio, string Inicio, string Fin, string Extra)
        {
            MOD.ModificarCua(Periodo, Anio, Inicio, Fin, Extra);
        }
        public void ModificarMed(string correo, string Nombre, string App, string Apm, string telefono, string horario, string especialidad, string extra)
        {
            MOD.ModificarMedico(correo, Nombre, App, Apm, telefono, horario, especialidad, extra);
        }
        public void ModificarIncap(string Periodo, string Comprobacion, string Extra, int F_positivoProfe)
        {
            MOD.ModificarIncapac(Periodo, Comprobacion, Extra, F_positivoProfe);
        }
        public void ModificaPosProf(string FechaConfirmado, string Antecedentes, string Comprobacion, string Riesgo, int NumContaio, string Extra, int F_Profe)
        {
            MOD.ModificarPosProfe(FechaConfirmado, Antecedentes, Comprobacion, Riesgo, NumContaio, Extra, F_Profe);
        }
        public void ModificarPosAl(string FechaConfirmado, string Antecedentes, string Comprobacion, string Riesgo, int NumContagio, string Extra, int F_Alumno)
        {
            MOD.ModificarPosAlum(FechaConfirmado, Antecedentes, Comprobacion, Riesgo, NumContagio, Extra, F_Alumno);
        }
        public void ModificarGrpCuat(int Id_GruCuat, int F_ProgEd, int F_Grupo, int F_Cuatri, string Turno, string Modalidad, string Extra)
        {
            MOD.ModificarGruCua(Id_GruCuat, F_ProgEd, F_Grupo, F_Cuatri, Turno, Modalidad, Extra);
        }
        public void ModificarAlGrp(int ID_AlumnGru, int F_Alumno, int F_GruCuat, string Extra, string Extra2)
        {
            MOD.ModificarAlGru(ID_AlumnGru, F_Alumno, F_GruCuat, Extra, Extra2);
        }
        public void ModificarProfGrp(int ID_ProfeGru, int F_Profe, int F_GruCuat, string Extra, string Extra2)
        {
            MOD.ModificarProfGru(ID_ProfeGru, F_Profe, F_GruCuat, Extra, Extra2);
        }
        public void ModificarSegPro(int id_Segui,int F_positivoProfe, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            MOD.ModificarSegProf(id_Segui,F_positivoProfe, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
        }
        public void ModificarSegAL(int Id_Seguimiento, int F_positivoAL, int F_medico, string Fecha, string Form_Comunica, string Reporte, string Entrevista, string Extra)
        {
            MOD.ModificarSegALUM(Id_Seguimiento, F_positivoAL, F_medico, Fecha, Form_Comunica, Reporte, Entrevista, Extra);
        }
    }
}
