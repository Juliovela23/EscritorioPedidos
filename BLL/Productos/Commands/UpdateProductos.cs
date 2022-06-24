using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Productos.DataSetProductosTableAdapters;
namespace BLL.Productos.Commands
{
    public class UpdateProductos
    {
        categoria_productosTableAdapter logicaCat;
        productosTableAdapter logicaProducto;
        public UpdateProductos()
        {
            logicaProducto = new productosTableAdapter();
            logicaCat = new categoria_productosTableAdapter();
        }

        public string Actualizar_producto(string Nombre_producto, string Descripcion_producto, decimal Precio_p, string Marca, int? Id_categoriaP, int Id_productos)
        {
            try
            {
                logicaProducto.UpdateQueryProductos(Nombre_producto, Descripcion_producto, Precio_p, Marca, Id_categoriaP, Id_productos);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
        public string DeleteP(int Id_productos)
        {
            try
            {
                logicaProducto.DeleteQueryProductos(Id_productos);
                return ("Se ha eliminado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
        public string DeleteC(int Id_categoria)
        {
            try
            {
                logicaCat.DeleteQueryCategoria(Id_categoria);
                return ("Se ha eliminado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
        public string Actualizar_categoriaProducto(string Nombre_cat, string Descripcion_categoria, int Id_categoriaP)
        {
            try
            {
                logicaCat.UpdateQueryCategoriaProducto(Nombre_cat, Descripcion_categoria, Id_categoriaP);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
    }
}
