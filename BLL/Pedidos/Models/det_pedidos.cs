using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pedidos.Models
{
   public class det_pedidos
    {
        public int Cantidad_pedida { get; set; }
        public decimal Precio_producto { get; set; }
        public int Id_productos { get; set; }
    }
}
