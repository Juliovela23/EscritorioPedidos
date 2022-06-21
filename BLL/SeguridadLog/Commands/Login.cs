using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.SeguridadLog.Models;
using DAL.SeguridadLog.DataSetSeguridadTableAdapters;
using System.Data;
namespace BLL.SeguridadLog.Commands
{
    public class Login
    {
        private LoginTableAdapter logicaLogin;
        public Models.Login userData;
        public Login()
        {
            logicaLogin = new LoginTableAdapter();
            userData = new Models.Login();
        }

        public Models.Login Inicio(string _usuario, string _passwd)
        {
            DataTable Resultado = logicaLogin.GetDataLogin(_usuario, _passwd);
            try
            {
                if (Resultado.Rows.Count < 1)
                {
                    userData.Validate = false;
                    userData.Nombres = "Esta cuenta no existe";
                    return userData;
                }
                else
                {
                    userData.Validate = true;
                    //Datos personales
                    userData.Id_persona = Convert.ToInt32(Resultado.Rows[0]["Id_personas"].ToString());
                    userData.Nombres = Resultado.Rows[0]["Nombres"].ToString();
                    userData.Apellidos = Resultado.Rows[0]["Apellidos"].ToString();
                    userData.Telefono = Resultado.Rows[0]["Telefono"].ToString(); 
                    userData.Genero = Convert.ToInt32(Resultado.Rows[0]["Genero"].ToString());
                    userData.Correo_electronico = Resultado.Rows[0]["Correo_electronico"].ToString();
                    //Datos de empleado
                    userData.Id_empleado = Convert.ToInt32(Resultado.Rows[0]["Id_empleado"].ToString());
                    userData.Estado_empleado = Convert.ToInt16(Resultado.Rows[0]["Estado"].ToString());
                    //Datos de usuario
                    userData.Id_usuario = Convert.ToInt32(Resultado.Rows[0]["Id_usuarios"].ToString());
                    userData.Usuario = Resultado.Rows[0]["Usuario"].ToString();
                    userData.Password = Resultado.Rows[0]["Password"].ToString();
                    return userData;
                }
            }
            catch (Exception error)
            {
                userData.Validate = false;
                userData.Nombres = error.Message;
                return userData;
            }
        }
    }
}
