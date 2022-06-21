using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Ciudades.Models
{
    public class Ciudades
    {
        public int? Id_ciudad { get; set; }
        public string Nombre_ciudad { get; set; }
        public string Pais { get; set; }
        public string Region_O_Departamento { get; set; }
        public string Elevacion_sobre_Mar { get; set; }
        public string Indice_robos { get; set; }
        public string Ingresos_promedio { get; set; }

    }
}
