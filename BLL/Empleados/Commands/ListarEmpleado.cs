using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados.DataSetEmpleadosTableAdapters;
using DAL.SeguridadLog.DataSetSeguridadTableAdapters;
using System.Data;
using System.Collections;
namespace BLL.Empleados.Commands
{
    public class ListarEmpleado
    {
        PersonasXempleadosTableAdapter logicaEmpleados;
        LoginTableAdapter logicaLogin;
        public ListarEmpleado()
        {
            logicaEmpleados = new PersonasXempleadosTableAdapter();
            logicaLogin = new LoginTableAdapter();
        }
        public ArrayList obtenerCliente(int Id_personaBus)
        {
            ArrayList datoEmpleado = new ArrayList();
            DataTable datos = logicaEmpleados.GetDataByIdPersonas(Id_personaBus);
            string Nombres = datos.Rows[0]["Nombres"].ToString();
            datoEmpleado.Add(Nombres);
            string Apellidos = datos.Rows[0]["Apellidos"].ToString();
            datoEmpleado.Add(Apellidos);
            string Genero = datos.Rows[0]["Telefono"].ToString();
            datoEmpleado.Add(Genero);
            string Direccion = datos.Rows[0]["Direccion"].ToString();
            datoEmpleado.Add(Direccion);
            string Telefono = datos.Rows[0]["Telefono"].ToString();
            datoEmpleado.Add(Telefono);
            string CUI = datos.Rows[0]["CUI"].ToString();
            datoEmpleado.Add(CUI);
            string Usuario = datos.Rows[0]["Usuario"].ToString();
            datoEmpleado.Add(Usuario);
            string Correo_electronico = datos.Rows[0]["Correo_electronico"].ToString();
            datoEmpleado.Add(Correo_electronico);
            string Password = datos.Rows[0]["Password"].ToString();
            datoEmpleado.Add(Password);
      
            string Id_empleado = datos.Rows[0]["Id_empleado"].ToString();
            datoEmpleado.Add(Id_empleado);
            string Id_persona = datos.Rows[0]["Id_personas"].ToString();
            datoEmpleado.Add(Id_persona);
            string Id_usuarios = datos.Rows[0]["Id_usuarios"].ToString();
            datoEmpleado.Add(Id_usuarios);
            

            return datoEmpleado;

        }
        public ArrayList obtenerUser(int Id_user)
        {
            ArrayList datoEmpleado = new ArrayList();
            DataTable datos = logicaLogin.GetDataByIdUser(Id_user);
            string Nombres = datos.Rows[0]["Nombres"].ToString();
            datoEmpleado.Add(Nombres);
            string Apellidos = datos.Rows[0]["Apellidos"].ToString();
            datoEmpleado.Add(Apellidos);
            return datoEmpleado;

        }
        public DataTable listadoPersonas()
        {
            return logicaEmpleados.GetDataByEstado();

        }
    }
}
