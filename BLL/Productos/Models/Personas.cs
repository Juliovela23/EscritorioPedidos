using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Productos.Models
{
   public class Personas
    {
        #region Productos
        public int? Id_productos { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public decimal Precio_p { get; set; }
        public string Marca { get; set; }
        public int Id_categoriaP { get; set; }
        #endregion

        #region CategoriaProductos
        public int? Id_categoriaP1 { get; set; }
        public string Nombre_cat { get; set; }
        public string Descripcion_categoria { get; set; }
        #endregion
    }
}
