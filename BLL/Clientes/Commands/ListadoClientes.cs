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
        public ListadoClientes()
        {
            logicaClientes = new clientesTableAdapter();
            logicaClientePersonas = new ClientesXpersonasTableAdapter();
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
