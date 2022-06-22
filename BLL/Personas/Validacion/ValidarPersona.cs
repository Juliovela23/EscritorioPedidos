using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL.Personas.Validacion
{
    public class ValidarPersona
    {
        #region methods
        public int ValidarNombrePersona(String user)
        {
            if (user.Length < 3)
                return 0;
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-Z]");
            //Si no contiene letras retorna false
            if (!letras.IsMatch(user))
                return 2;
            //si cumple con todo, regresa true
            return 1;
        }

        public int ValidarCUI(String value)
        {
            //Verificar longitud
            if (value.Length < 13)
                return 0;
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //si no contiene digitos numeros retorna false
            if (!numeros.IsMatch(value))
                return 2;
            //si cumple con todo, regresa true
            return 1;
        }
        #endregion
    }
}
