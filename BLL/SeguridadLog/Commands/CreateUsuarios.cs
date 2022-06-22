using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL.SeguridadLog.DataSetSeguridadTableAdapters;

using System.Collections;
using System.Data;
namespace BLL.SeguridadLog.Commands
{
    public class CreateUsuarios
    {
        private LoginTableAdapter logicaLogin;
        private usuariosTableAdapter logicaUser;
        public CreateUsuarios()
        {
            logicaLogin = new LoginTableAdapter();
            logicaUser = new usuariosTableAdapter();
        }
        public string VerificarUser(string _user)
        {
            try
            {
                DataTable D2 = logicaUser.GetDataByUser(_user);
                if (D2.Rows.Count < 1)
                {
                    return "Libre";
                }
                else
                {
                    return "ERROR: Usuario Invalido";
                }

            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
        public string CrearUsuarios(string Usuario, string Password, string Correo_electronico, int? Id_empleado)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    logicaUser.InsertQueryUsuario(Usuario,Password,Correo_electronico,Id_empleado);
                    respuesta = "Usuario creado con exito";
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
