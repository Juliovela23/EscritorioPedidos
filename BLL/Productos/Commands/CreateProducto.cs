using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Transactions;
using System.Collections;
using DAL.Productos.DataSetProductosTableAdapters; 
namespace BLL.Productos.Commands

{
    public class CreateProducto
    {
        private productosTableAdapter logicaProducto;
        public CreateProducto()
        {
            logicaProducto = new productosTableAdapter();
        }
        public string CrearProducto(string Nombre_producto, string Descripcion_producto, decimal Precio_p, string Marca, int? Id_categoriaP)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    logicaProducto.InsertQueryProductos(Nombre_producto, Descripcion_producto,Precio_p,Marca, Id_categoriaP);
                    
                    respuesta = "Producto creado con exito";
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
