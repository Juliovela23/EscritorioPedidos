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
        public int id_empleado;
        public int Id_persona;


        public CreateEmpleados()
        {
            LogicaEmpleados = new empleadosTableAdapter();
            LogicaPersonas = new personasTableAdapter();

        }
        public int ultimo_id()
        {
            try
            {
                DataTable D1 = LogicaEmpleados.GetDataByultimoinsert();
                if (D1.Rows.Count < 1)
                {
                    return -1;
                }
                else
                {
                    id_empleado = Convert.ToInt32(D1.Rows[0]["Id_empleado"]);
                    return Convert.ToInt32(id_empleado);
                }
            }
            catch (Exception)
            {
                return -1;
            }
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
        public string VerificarDPI(string _CUI)
        {
            try
            {
                DataTable D2 = LogicaPersonas.GetDatabyCUI(_CUI);
                if (D2.Rows.Count < 1)
                {
                    return "Libre";
                }
                else
                {
                    return "ERROR: Ya existe una persona con este CUI";
                }

            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
        public string CrearEmpleados(string Nombres, string Apellidos, short? Genero, DateTime? Fecha_nacimiento, string CUI, string Telefono, string Direccion, short Estado)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    LogicaPersonas.InsertQueryPersonas(Nombres, Apellidos, Genero, Fecha_nacimiento, CUI, Telefono, Direccion);
                    ultimo_idp();
                    LogicaEmpleados.InsertQueryEmpleados(Estado, Convert.ToInt32(Id_persona));
                    ultimo_id();
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
