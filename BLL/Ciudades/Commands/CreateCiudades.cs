using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Transactions;
using DAL.Ciudades.DataSetCiudadesTableAdapters;
namespace BLL.Ciudades.Commands
{
    public class CreateCiudades
    {
        private ciudadesTableAdapter logicaCiudad;
        public CreateCiudades()
        {
            logicaCiudad = new ciudadesTableAdapter();
        }
        public DataTable listadoCiudad()
        {
            return logicaCiudad.GetDataCiudades();

        }
        public string CrearCiudad(string Nombre_ciudad, string Pais, string Region_O_Departamento, string Elevacion_sobre_Mar, string Indice_robos, string Ingresos_promedio)
        {
            string respuesta = "";
            TransactionScope Tran = new TransactionScope();
            using (Tran)
            {
                try
                {

                    logicaCiudad.InsertQueryCiudad(Nombre_ciudad,Pais,Region_O_Departamento,Elevacion_sobre_Mar,Indice_robos,Ingresos_promedio);
                    
                    respuesta = "Ciudad creada con exito";
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
