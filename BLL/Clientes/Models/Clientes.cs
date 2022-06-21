using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Clientes.Models
{
    public class Clientes
    {
        public int? Id_cliente  { get; set; }
        public string Estado_cliente { get; set; }
        public int Id_personas { get; set; }
        public int Id_ciudad { get; set; }
       
    }
}
