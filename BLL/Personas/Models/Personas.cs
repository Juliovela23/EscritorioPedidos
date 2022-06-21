using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Personas.Models
{
   public class Personas
    {
        public int? Id_personas { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Genero { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string CUI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
