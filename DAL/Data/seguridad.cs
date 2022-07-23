using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Properties;

namespace DAL.Data
{
   public class seguridad
    {
        public string a()
        {
            return Settings.Default.bd_pedidoswebConnectionString;
        }
    }
}
