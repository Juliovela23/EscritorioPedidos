using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Reportes
{
    public class Reportes1
    {
        Data.Sql CONNECT;
        public Reportes1()
        {
            CONNECT = new Data.Sql();
        }
        public DataTable Listrep1(string Nombre, string fecha1, string fecha2)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT  COUNT(C.Id_cliente)as '# Clientes',Ciu.Nombre_ciudad FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN productos as Pr ON Pr.Id_productos = Det.Id_productos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where Pr.Nombre_producto='" + Nombre + "' AND P.Fecha_pedido BETWEEN '" + fecha1 + "' AND '" + fecha2 + "' GROUP BY Ciu.Nombre_ciudad ", cadena);
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

        public DataTable ListTodoRep1(string fecha1, string fecha2)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT  COUNT(C.Id_cliente)as '# Clientes',Ciu.Nombre_ciudad FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN productos as Pr ON Pr.Id_productos = Det.Id_productos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where P.Fecha_pedido BETWEEN '" + fecha1 + "' AND '" + fecha2 + "' GROUP BY Ciu.Nombre_ciudad ", cadena);
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

        public DataTable Listrep2(string Nombre,string Estado, string fecha1, string fecha2)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(Per.Nombres,'',Per.Apellidos)as 'Nombre Completo', Per.Telefono, Per.Direccion FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN personas as Per on Per.Id_personas=C.Id_Personas INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where Ciu.Nombre_ciudad ='"+Nombre+"' AND P.Estado_pedido='"+ Estado + "'AND P.Fecha_pedido BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'" , cadena);
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
        public DataTable Listrep2SinFecha(string Nombre, string Estado)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(Per.Nombres,'',Per.Apellidos)as 'Nombre Completo', Per.Telefono, Per.Direccion FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN personas as Per on Per.Id_personas=C.Id_Personas INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where Ciu.Nombre_ciudad ='" + Nombre + "' AND P.Estado_pedido='" + Estado + "'", cadena);
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
        public DataTable Listrep2Todos(string Nombre, string fecha1, string fecha2)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(Per.Nombres,'',Per.Apellidos)as 'Nombre Completo', Per.Telefono, Per.Direccion FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN personas as Per on Per.Id_personas=C.Id_Personas INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where Ciu.Nombre_ciudad ='" + Nombre + "' BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'", cadena);
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
        public DataTable Listrep2TodosFechas(string Nombre)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT CONCAT(Per.Nombres,'',Per.Apellidos)as 'Nombre Completo', Per.Telefono, Per.Direccion FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN personas as Per on Per.Id_personas=C.Id_Personas INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where Ciu.Nombre_ciudad ='" + Nombre + "'", cadena);
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

        public DataTable Listrep3( string fecha1, string fecha2)
        {

            try
            {
                MySql.Data.MySqlClient.MySqlConnection cadena = new MySql.Data.MySqlClient.MySqlConnection
                 (CONNECT.b());
                MySql.Data.MySqlClient.MySqlDataAdapter export = new MySql.Data.MySqlClient.MySqlDataAdapter
                (
                    "SELECT P.Fecha_pedido,p.Numero_de_orden ,CONCAT(Per.Nombres,'',Per.Apellidos)as 'Cliente',SUM(Det.Cantidad_pedida) as '#Productos' ,SUM(Det.Precio_producto) as 'Monto',P.Estado_pedido   FROM pedidos as P INNER JOIN detalle_pedido as Det on Det.Id_pedidos=P.Id_pedidos INNER JOIN clientes as C on P.Id_cliente= C.Id_cliente INNER JOIN personas as Per on Per.Id_personas=C.Id_Personas INNER JOIN ciudades as Ciu on Ciu.Id_ciudad = C.Id_ciudad where P.Fecha_pedido BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'GROUP BY P.Id_pedidos", cadena);
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
    }
}
