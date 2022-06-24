using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Personas.DataSetPersonasTableAdapters;
using DAL.Clientes.DataSetClientesTableAdapters;
using DAL.SeguridadLog.DataSetSeguridadTableAdapters;
namespace BLL.Clientes.Commands
{
    public class UpdateCliente
    {
        personasTableAdapter logicaPersonas;
        clientesTableAdapter logicaClientes;
        public UpdateCliente()
        {
            logicaClientes = new clientesTableAdapter();
            logicaPersonas = new personasTableAdapter();
        }
        public string Actualizar_Cliente(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, int Id_personas, short Estado_cliente, string NIT, int Id_cliente)
        {
            try
            {
                logicaPersonas.UpdateQueryPersona(Nombres, Apellidos, Genero, Fecha_nacimiento, CUI, Telefono, Direccion, Id_personas);
                logicaClientes.UpdateQueryCliente(Estado_cliente, NIT,Id_cliente);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
    }
}
