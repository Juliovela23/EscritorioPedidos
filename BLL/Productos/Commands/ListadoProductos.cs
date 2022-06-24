using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Productos.DataSetProductosTableAdapters;

namespace BLL.Productos.Commands
{
    public class ListadoProductos
    {
        categoria_productosTableAdapter logicaCat;
        productosTableAdapter logicaProducto;
        public ListadoProductos()
        {
            logicaCat = new categoria_productosTableAdapter();
            logicaProducto = new productosTableAdapter();
        }
        public DataTable listadoCatProducto()
        {
            return logicaCat.GetDataCategoriaP();

        }
        public DataTable listadoProducto()
        {
            return logicaProducto.GetDataProductos();

        }
        public ArrayList obtenerCategoria(int Id_cat)
        {
            ArrayList datoProducto = new ArrayList();
            DataTable datos = logicaCat.GetDataByCategoriaID(Id_cat);
            string Nombre_cat = datos.Rows[0]["Nombre_cat"].ToString();
            datoProducto.Add(Nombre_cat);
            string Descripcion_categoria = datos.Rows[0]["Descripcion_categoria"].ToString();
            datoProducto.Add(Descripcion_categoria);


            return datoProducto;

        }
        public ArrayList obtenerProducto(int Id_productos)
        {
            ArrayList datoProducto = new ArrayList();
            DataTable datos = logicaProducto.GetDataById_producto(Id_productos);
            string Nombre_productos = datos.Rows[0]["Nombre_producto"].ToString();
            datoProducto.Add(Nombre_productos);
            string Descripcion_producto = datos.Rows[0]["Descripcion_producto"].ToString();
            datoProducto.Add(Descripcion_producto);
            decimal Precio_P =Convert.ToDecimal( datos.Rows[0]["Precio_p"].ToString());
            datoProducto.Add(Precio_P);
            string Marca = datos.Rows[0]["Marca"].ToString();
            datoProducto.Add(Marca);
            string Id_categoriaP = datos.Rows[0]["Id_categoriaP"].ToString();
            datoProducto.Add(Id_categoriaP);

            return datoProducto;

        }
    }
}
