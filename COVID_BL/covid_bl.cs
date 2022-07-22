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
        covid_dal BD = new covid_dal();

        public DataTable Civil()
        {
            return BD.ConsultaCivil();
        }

    }
}
