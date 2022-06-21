using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Transactions;
using DAL.Clientes.DataSetClientesTableAdapters;
using DAL.Personas.DataSetPersonasTableAdapters;

namespace BLL.Clientes.Commands
{
    public class CreateCliente
    {
        private clientesTableAdapter logicaCliente;
        private personasTableAdapter LogicaPersonas;
        public CreateCliente()
        {
            logicaCliente = new clientesTableAdapter();
        }
        public string CrearCliente(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, short Estado, int? Id_personas, int? Id_ciudad)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {
                    LogicaPersonas.InsertQueryPersonas(Nombres, Apellidos, Genero, Fecha_nacimiento, CUI, Telefono, Direccion);
                    logicaCliente.InsertQueryClientes(Estado, Id_personas, Id_ciudad);
                    respuesta = "Cliente creado con exito";
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
