using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados.DataSetEmpleadosTableAdapters;
using DAL.Personas.DataSetPersonasTableAdapters;
using DAL.SeguridadLog.DataSetSeguridadTableAdapters;
namespace BLL.Empleados.Commands
{
    public class UpdateEmpleado
    {
        empleadosTableAdapter logicaEmpleado;
        personasTableAdapter logicaPersona;
        usuariosTableAdapter logiUser;
        public UpdateEmpleado()
        {
            logicaEmpleado = new empleadosTableAdapter();
            logicaPersona = new personasTableAdapter();
            logiUser = new usuariosTableAdapter();
        }

        public string Actualizar_Empleado(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, int Id_personas, short Estado, int Id_empleado, string Usuario, string Password, string Correo_electronico, int Id_usuarios)
        {
            try
            {
                logicaPersona.UpdateQueryPersona(Nombres,Apellidos,Genero,Fecha_nacimiento,CUI,Telefono,Direccion,Id_personas);
                logicaEmpleado.UpdateQueryEmpleado(Estado,Id_personas,Id_empleado);
                logiUser.UpdateQueryUsuarios(Usuario, Password, Correo_electronico, Id_empleado, Id_usuarios);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
    }
}
