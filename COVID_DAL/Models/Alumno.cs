using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_DAL.Models
{
    public class Alumno
    {
        public string Matricula { set; get; }
        public string Nombre { set; get; }
        public string Ap_pat { set; get; }
        public string Ap_mat { set; get; }
        public string Genero { set; get; }
        public string Correo { set; get; }
        public string Celular { set; get; }
        public string F_EdoCivil { set; get; }
        public int F_Nivel { set; get; }
    }
}
