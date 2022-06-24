using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Pedidos.DataSetPedidosTableAdapters;
namespace BLL.Pedidos.Commands
{
    public class ListadoPedidos
    {
        pedidosTableAdapter logicaPedidos;
        public ListadoPedidos()
        {
            logicaPedidos = new pedidosTableAdapter();
        }
        public DataTable listadoPedidos()
        {
            return logicaPedidos.GetDataPedidos();

        }
        public ArrayList obtenerPedidos(int Id_pedidos)
        {
            ArrayList datoPedido = new ArrayList();
            DataTable datos = logicaPedidos.GetDataById(Id_pedidos);
            DateTime Fecha_pedido =Convert.ToDateTime( datos.Rows[0]["Fecha_pedido"].ToString());
            datoPedido.Add(Fecha_pedido);
            string Estado_pedido = datos.Rows[0]["Estado_pedido"].ToString();
            datoPedido.Add(Estado_pedido);
            string Monto_total = datos.Rows[0]["Monto_total"].ToString();
            datoPedido.Add(Monto_total);
            string Id_usuarios = datos.Rows[0]["Id_usuarios"].ToString();
            datoPedido.Add(Id_usuarios);
            string Id_cliente = datos.Rows[0]["Id_cliente"].ToString();
            datoPedido.Add(Id_cliente);

            return datoPedido;

        }
    }
}
