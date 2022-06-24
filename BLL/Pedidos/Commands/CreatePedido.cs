using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Transactions;
using DAL.Pedidos.DataSetPedidosTableAdapters;
using BLL.Pedidos.Models;
using System.Collections;

namespace BLL.Pedidos.Commands
{
    public class CreatePedido
    {
        private pedidosTableAdapter logicapedido;
        private detalle_pedidoTableAdapter logicadetalle;
        string Id_pedidos1;
        public CreatePedido()
        {
            logicadetalle = new detalle_pedidoTableAdapter();
            logicapedido = new pedidosTableAdapter();
        }
        public int ultimo_id()
        {
            try
            {
                DataTable D1 = logicapedido.GetUltimoinsert();
                if (D1.Rows.Count < 1)
                {
                    return -1;
                }
                else
                {
                    Id_pedidos1 = D1.Rows[0]["Id_pedidos"].ToString();
                    return Convert.ToInt32(Id_pedidos1);
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public string CreaPedido(DateTime Fecha_pedido, decimal Monto_total, int? Id_usuarios, int? Id_cliente, List<det_pedidos> listado,string numeroOrden)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    logicapedido.InsertQueryPedido(Fecha_pedido,"En proceso",Monto_total,Id_usuarios,Id_cliente, numeroOrden);
                    ultimo_id();
                    foreach (det_pedidos info in listado)
                    {
                        logicadetalle.InsertQueryDetalle_pedido(info.Cantidad_pedida, info.Precio_producto,  Convert.ToInt32(Id_pedidos1), info.Id_productos);
                    }
                    respuesta = "Pedido realizada con exito";
                    Tran.Complete();

                }
                catch (Exception error)
                {

                    respuesta = "ERROR:" + error.Message;
                }
            }
            return respuesta;
        }
    }
}
