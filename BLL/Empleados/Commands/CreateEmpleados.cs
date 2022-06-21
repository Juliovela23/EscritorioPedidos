using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados.DataSetEmpleadosTableAdapters;
using DAL.Personas.DataSetPersonasTableAdapters;
using System.Collections;
using System.Data;
using System.Transactions;
namespace BLL.Empleados.Commands
{

    public class CreateEmpleados
    {
        private empleadosTableAdapter LogicaEmpleados;
        private personasTableAdapter LogicaPersonas;
        
        public CreateEmpleados()
        {
            LogicaEmpleados = new empleadosTableAdapter();
            LogicaPersonas = new personasTableAdapter();

        }
        public string CrearEmpleados(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, short Estado, int? Id_personas)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    LogicaPersonas.InsertQueryPersonas(Nombres, Apellidos, Genero, Fecha_nacimiento, CUI, Telefono, Direccion);
                    LogicaEmpleados.InsertQueryEmpleados(Estado, Id_personas);
                    respuesta = "Empleado creado con exito";
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
