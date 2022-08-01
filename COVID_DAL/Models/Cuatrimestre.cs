using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_DAL.Models
{
    public class Cuatrimestre
    {
        public string Periodo { set; get; }
        public int anio { set; get; }
        public DateTime inicio { set; get; }
        public DateTime Fin { set; get; }

        public string Extra { set; get; }
    }
}
