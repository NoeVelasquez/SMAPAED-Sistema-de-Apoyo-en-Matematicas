using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMAPAED.ConexionMySQL;

namespace SMAPAED
{

    internal class ConexionMySQLyForm
    {
        ConexionMySQL cn = new ConexionMySQL();
        public int conMySQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }
    }
}
