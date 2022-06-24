using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Pedidos.DataSetPedidosTableAdapters;
namespace BLL.Pedidos.Commands
{
    public class UpdatePedidos
    {
        pedidosTableAdapter logicaPedidos;
        public UpdatePedidos()
        {
            logicaPedidos = new pedidosTableAdapter();
        }

        public string ActualizarPedidos(DateTime Fecha_pedido, string Estado_pedido, int? Id_cliente, int d_pedidos, string Numero_de_orden)
        {
            try
            {
                logicaPedidos.UpdateQueryPedidos(Fecha_pedido,Estado_pedido,Id_cliente, Numero_de_orden, d_pedidos);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
    }
}
