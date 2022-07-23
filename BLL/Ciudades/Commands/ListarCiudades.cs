using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Ciudades.DataSetCiudadesTableAdapters;
namespace BLL.Ciudades.Commands
{
    public class ListarCiudades
    {
        ciudadesTableAdapter logicaCiudades;
        Data.Sql CONNECT;
        public ListarCiudades()
        {
            logicaCiudades = new ciudadesTableAdapter();
            CONNECT = new Data.Sql();
        }
        public ArrayList obtenerCiudad(int Id_ciudad)
        {
            ArrayList datoProducto = new ArrayList();
            DataTable datos = logicaCiudades.GetDataById_ciudad(Id_ciudad);
            string departamento = datos.Rows[0]["Region_O_Departamento"].ToString();
            datoProducto.Add(departamento);
            string Nombre_Ciudad = datos.Rows[0]["Nombre_Ciudad"].ToString();
            datoProducto.Add(Nombre_Ciudad);
            string Pais = datos.Rows[0]["Pais"].ToString();
            datoProducto.Add(Pais);
            string Elevacion_sobre_Mar = datos.Rows[0]["Elevacion_sobre_Mar"].ToString();
            datoProducto.Add(Elevacion_sobre_Mar);
            string Indice_robos = datos.Rows[0]["Indice_robos"].ToString();
            datoProducto.Add(Indice_robos);
            string Ingresos_promedio = datos.Rows[0]["Ingresos_promedio"].ToString();
            datoProducto.Add(Ingresos_promedio);


            return datoProducto;

        }

        public DataTable listCiudadesNombre(string Nombre)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT Nombre_ciudad, Pais, Region_O_Departamento, Elevacion_sobre_Mar, Indice_robos, Ingresos_promedio " +
                    "FROM ciudades " +
                    "WHERE  Nombre_ciudad LIKE '%" + Nombre + "%'", cadena);
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
        public DataTable listCiudadesPais(string Nombre)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT Nombre_ciudad, Pais, Region_O_Departamento, Elevacion_sobre_Mar, Indice_robos, Ingresos_promedio " +
                    "FROM ciudades " +
                    "WHERE  Pais LIKE '%" + Nombre + "%'", cadena);
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
        public DataTable listCiudadesDepartamento(string Nombre)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT Nombre_ciudad, Pais, Region_O_Departamento, Elevacion_sobre_Mar, Indice_robos, Ingresos_promedio " +
                    "FROM ciudades " +
                    "WHERE  Region_O_Departamento LIKE '%" + Nombre + "%'", cadena);
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
        public DataTable listCiudadesTodas()
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT Nombre_ciudad, Pais, Region_O_Departamento, Elevacion_sobre_Mar, Indice_robos, Ingresos_promedio " +
                    "FROM ciudades " , cadena);
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
