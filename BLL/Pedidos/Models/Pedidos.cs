using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pedidos.Models
{
    public class Pedidos
    {
        #region pedidos
        public int? Id_pedidos { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public string Estado_pedido { get; set; }
        public decimal Monto_total { get; set; }
        public int Id_usuarios { get; set; }
        public int Id_cliente { get; set; }

        #endregion

        #region detallePedido
        public int? Id_detalle { get; set; }
        public int Cantidad_pedida { get; set; }
        public decimal Precio_producto { get; set; }
        public int Id_productos { get; set; }

        #endregion
    }
}
