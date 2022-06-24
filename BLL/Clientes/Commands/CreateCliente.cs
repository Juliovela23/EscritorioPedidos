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
        public int Id_persona;
        public CreateCliente()
        {
            logicaCliente = new clientesTableAdapter();
            LogicaPersonas = new personasTableAdapter();
        }
    
        public int ultimo_idp()
        {
            try
            {
                DataTable D1 = LogicaPersonas.GetDataByIdPersonas();
                if (D1.Rows.Count < 1)
                {
                    return -1;
                }
                else
                {
                    Id_persona = Convert.ToInt32(D1.Rows[0]["Id_personas"]);
                    return Convert.ToInt32(Id_persona);
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public string CrearCliente(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, int? Id_ciudad, string NIT)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {
                    LogicaPersonas.InsertQueryPersonas(Nombres, Apellidos, Genero, Fecha_nacimiento, CUI, Telefono, Direccion);
                    ultimo_idp();
                    logicaCliente.InsertQueryClientes(1, Id_persona, Id_ciudad,NIT);
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
