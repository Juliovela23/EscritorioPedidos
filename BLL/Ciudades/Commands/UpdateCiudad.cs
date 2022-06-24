using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Ciudades.DataSetCiudadesTableAdapters;
namespace BLL.Ciudades.Commands
{
    public class UpdateCiudad
    {
        ciudadesTableAdapter logicaCiudad;
        public UpdateCiudad()
        {
            logicaCiudad = new ciudadesTableAdapter();
        }
        public string ActualizarCiudad(string Nombre_ciudad, string Pais, string Region_O_Departamento, string Elevacion_sobre_Mar, string Indice_robos, string Ingresos_promedio, int Id_ciudad)
        {
            try
            {
                logicaCiudad.UpdateQueryCiudad(Nombre_ciudad, Pais, Region_O_Departamento, Elevacion_sobre_Mar, Indice_robos, Ingresos_promedio, Id_ciudad);
                return ("Se ha actualizado correctamente");
            }
            catch (Exception error)
            {
                return "ERROR:" + error.Message;
            }
        }
    }
}
