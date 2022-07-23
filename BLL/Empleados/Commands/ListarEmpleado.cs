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
        Data.Sql CONNECT;
        public ListarEmpleado()
        {
            logicaEmpleados = new PersonasXempleadosTableAdapter();
            logicaLogin = new LoginTableAdapter();
            CONNECT = new Data.Sql();
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

        public DataTable listEmpleados(string Nombre)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(P.Nombres,' ',P.Apellidos) as NombreCompleto, P.CUI, P.Fecha_nacimiento as Fecha_de_Nacimiento, " +
                    " CASE WHEN E.Estado = 0 THEN 'InActivo' " +
                    " WHEN E.Estado = 1 THEN 'Activo' " +
                    " ELSE 'No Especificado' END AS Estado " +
                    " FROM personas AS P INNER JOIN empleados as E ON E.Id_personas=P.Id_personas " +
                    " WHERE E.Estado = 1 AND P.nombres LIKE '%" + Nombre + "%'", cadena);
                DataTable tabla = new DataTable();
                export.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                DataTable tabla = new DataTable();
                return tabla;
            }

        }
        public DataTable TodosEmpleados()
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(P.Nombres,' ',P.Apellidos) as NombreCompleto, P.CUI, P.Fecha_nacimiento as Fecha_de_Nacimiento, " +
                    " CASE WHEN E.Estado = 0 THEN 'InActivo' " +
                    " WHEN E.Estado = 1 THEN 'Activo' " +
                    " ELSE 'No Especificado' END AS Estado " +
                    " FROM personas AS P INNER JOIN empleados as E ON E.Id_personas=P.Id_personas " +
                    " WHERE E.Estado = 1", cadena);
                DataTable tabla = new DataTable();
                export.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                DataTable tabla = new DataTable();
                return tabla;
            }

        }
    }
}
