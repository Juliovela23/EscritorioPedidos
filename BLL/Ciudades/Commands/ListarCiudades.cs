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
        public ListarCiudades()
        {
            logicaCiudades = new ciudadesTableAdapter();
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
    }
}
