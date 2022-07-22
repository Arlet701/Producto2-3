using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COVID_DAL.Models;
using COVID_DAL;
using System.Data;

namespace COVID_BL
{
    public class covid_bl
    {
        Consulta BD = new Consulta();

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
    }
}
