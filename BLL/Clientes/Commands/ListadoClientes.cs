using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Clientes.DataSetClientesTableAdapters;
namespace BLL.Clientes.Commands
{
    public class ListadoClientes
    {
        clientesTableAdapter logicaClientes;
        ClientesXpersonasTableAdapter logicaClientePersonas;
        Data.Sql CONNECT;
        public ListadoClientes()
        {
            logicaClientes = new clientesTableAdapter();
            CONNECT = new Data.Sql();

            logicaClientePersonas = new ClientesXpersonasTableAdapter();
        }

        public DataTable listClientes(string Nombre) {
            
                try
                {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT C.NIT, CONCAT(P.Nombres,' ',P.Apellidos) as NombreCompleto, P.CUI, P.Fecha_nacimiento as Fecha_de_Nacimiento, " +
                    " CASE WHEN C.Estado_cliente = 0 THEN 'InActivo' " +
                    " WHEN C.Estado_cliente = 1 THEN 'Activo' " +
                    " ELSE 'No Especificado' END AS Estado ," +
                    " Ciu.Nombre_ciudad AS Ciudad FROM personas AS P INNER JOIN clientes as C ON C.Id_personas=P.Id_personas " +
                    "INNER JOIN ciudades as Ciu ON C.Id_ciudad=Ciu.Id_ciudad WHERE C.Estado_cliente = 1 AND P.nombres LIKE '%" + Nombre +"%'" , cadena);
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
        public DataTable TodosClientes()
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT C.NIT, CONCAT(P.Nombres,' ',P.Apellidos) as NombreCompleto, P.CUI, P.Fecha_nacimiento as Fecha_de_Nacimiento, " +
                    " CASE WHEN C.Estado_cliente = 0 THEN 'InActivo' " +
                    " WHEN C.Estado_cliente = 1 THEN 'Activo' " +
                    " ELSE 'No Especificado' END AS Estado ," +
                    " Ciu.Nombre_ciudad AS Ciudad FROM personas AS P INNER JOIN clientes as C ON C.Id_personas=P.Id_personas " +
                    "INNER JOIN ciudades as Ciu ON C.Id_ciudad=Ciu.Id_ciudad WHERE C.Estado_cliente = 1", cadena);
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
        public DataTable listadoClientesNIT(string Nit)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT C.NIT, CONCAT(P.Nombres,' ',P.Apellidos) as NombreCompleto, P.CUI, P.Fecha_nacimiento as Fecha_de_Nacimiento, " +
                    " CASE WHEN C.Estado_cliente = 0 THEN 'InActivo' " +
                    " WHEN C.Estado_cliente = 1 THEN 'Activo' " +
                    " ELSE 'No Especificado' END AS Estado ," +
                    " Ciu.Nombre_ciudad AS Ciudad FROM personas AS P INNER JOIN clientes as C ON C.Id_personas=P.Id_personas " +
                    "INNER JOIN ciudades as Ciu ON C.Id_ciudad=Ciu.Id_ciudad WHERE C.Estado_cliente = 1 AND C.NIT LIKE '%" + Nit + "%'", cadena);
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
        public DataTable listadoClientes()
        {
            return logicaClientes.GetDataClientes();

        }
        public DataTable listadoPersonas()
        {
            return logicaClientePersonas.GetDataClientesPersonas();

        }
        public ArrayList obtenerCliente(int Id_cliente)
        {
            ArrayList datoCliente = new ArrayList();
            DataTable datos = logicaClientePersonas.GetDataById_Cliente(Id_cliente);
            string Telefono = datos.Rows[0]["Telefono"].ToString();
            datoCliente.Add(Telefono);
            string NIT = datos.Rows[0]["NIT"].ToString();
            datoCliente.Add(NIT);
      
            return datoCliente;

        }

        public ArrayList obtenerClienteXpersona(int Id_persona)
        {
            ArrayList datoCliente = new ArrayList();
            DataTable datos = logicaClientePersonas.GetDataById_personaClie(Id_persona);
            string Telefono = datos.Rows[0]["Telefono"].ToString();
            datoCliente.Add(Telefono);
            string NIT = datos.Rows[0]["NIT"].ToString();
            datoCliente.Add(NIT);
            string Nombres = datos.Rows[0]["Nombres"].ToString();
            datoCliente.Add(Nombres);
            string Apellidos = datos.Rows[0]["Apellidos"].ToString();
            datoCliente.Add(Apellidos);
            string Genero = datos.Rows[0]["Telefono"].ToString();
            datoCliente.Add(Genero);
            string Direccion = datos.Rows[0]["Direccion"].ToString();
            datoCliente.Add(Direccion);
            string CUI = datos.Rows[0]["CUI"].ToString();
            datoCliente.Add(CUI);
            
            string Id_ciudad = datos.Rows[0]["Id_ciudad"].ToString();
            datoCliente.Add(Id_ciudad);
            string Id_cliente = datos.Rows[0]["Id_cliente"].ToString();
            datoCliente.Add(Id_cliente);
            return datoCliente;

        }
    }
}
