using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Data;

namespace BLL.Data
{
   public class Sql
    {
        readonly DAL.Data.seguridad julio;
        public Sql()
        {
            julio = new seguridad();
        }
        public string b()
        {
            return julio.a();
        }
    }
}
