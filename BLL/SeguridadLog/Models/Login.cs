using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SeguridadLog.Models
{
    public class Login
    {

        #region propierties
        public bool? Validate { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo_electronico { get; set; }
        public int? Genero { get; set; }
        public short? Estado_empleado { get; set; }
        public int? Id_empleado { get; set; }
        public int? Id_persona { get; set; }
        public int? Id_usuario { get; set; }
        #endregion

    }
}
