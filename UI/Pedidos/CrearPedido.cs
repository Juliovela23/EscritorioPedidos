using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Productos.Commands;
using BLL.Pedidos.Commands;
using BLL.Clientes.Commands;
using BLL.Pedidos.Models;
using System.Collections;

namespace UI.Pedidos
{
    public partial class CrearPedido : Form
    {
        ArrayList DatosProductos = new ArrayList();

        ArrayList DatosClientes= new ArrayList();
        ListadoProductos logicaProductos;
        ListadoClientes logicaClientes;
        CreatePedido logicaPedido;
        int i = 0;
        BLL.SeguridadLog.Models.Login Usuario;
        public CrearPedido(BLL.SeguridadLog.Models.Login Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
            logicaProductos = new ListadoProductos();
            logicaPedido = new CreatePedido();
            logicaClientes = new ListadoClientes();
        }
        void CargaProducto()
        {
            comboProducto.DataSource = logicaProductos.listadoProducto();
            comboProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboProducto.DisplayMember = "Nombre_producto";
            comboProducto.ValueMember = "Id_productos";
            comboProducto.Refresh();
        }
        void CargaClientes()
        {
            comboSocio.DataSource = logicaClientes.listadoPersonas();
            comboSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboSocio.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboSocio.DisplayMember = "Nombres";
            comboSocio.ValueMember = "Id_cliente";
            comboSocio.Refresh();
        }
        private void CrearPedido_Load(object sender, EventArgs e)
        {
            CargaProducto();
            Lbl_empleado.Text = Usuario.Nombres + " " + Usuario.Apellidos;
            CargaClientes();
        }

        private void comboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DatosProductos.Clear();
                DatosProductos = logicaProductos.obtenerProducto(Convert.ToInt32(comboProducto.SelectedValue.ToString()));
                txt_Descripcion.Text = DatosProductos[1].ToString();
                txt_precio.Text = DatosProductos[2].ToString();
                txt_Marca.Text = DatosProductos[3].ToString();


            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        private void but_agregar_Click(object sender, EventArgs e)
        {
            string Pr, Marca, precio, Descripcion, existencia, cantidad;
            Pr = comboProducto.Text;
            
            Marca = txt_Marca.Text;
            double cantidadx = Convert.ToDouble(txt_cantidadComprada.Text) * Convert.ToDouble(txt_precio.Text);
            precio = Convert.ToString(cantidadx);
            Descripcion = txt_Descripcion.Text;
            
            cantidad = txt_cantidadComprada.Text;
            i = i + 1;

            if (txt_cantidadComprada.Text == "")
            {
                MessageBox.Show("Por favor ingresar la cantidad que comprara", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                 dataproducto.Rows.Add( Pr, Marca, Descripcion, cantidad, cantidadx);
                 listboxId.Items.Add(Convert.ToInt32(comboProducto.SelectedValue));
                 ListboxPrecio.Items.Add(precio);
                 Listboxcantidad.Items.Add(cantidad);
                 listBox1.Items.Add(precio);
                 double suma = 0;
                 for (int i = 0; i < listBox1.Items.Count; i++)
                 {
                    suma += Convert.ToDouble(listBox1.Items[i].ToString());
                    txtTotal.Text = suma.ToString();

                 }

                
            }
        }

        private void butoncrear_Click(object sender, EventArgs e)
        {
            DateTime fechaventa = Fechaventa.Value.Date;
            if (ListboxPrecio.Items.Count <= 0)
            {
                MessageBox.Show("Por favor debe ingresar productos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Está seguro del pedido?", "Proceso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_orden.Text==" ") {
                        MessageBox.Show("Por favor Coloque el numero de pedido","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else { 
                    string respuesta = "";
                    List<det_pedidos> listadoProductos = new List<det_pedidos>();
                    det_pedidos item;

                    for (int i = 0; i < listboxId.Items.Count; i++)
                    {
                        item = new det_pedidos();
                        item.Id_productos = Convert.ToInt32(listboxId.Items[i].ToString());
                        item.Cantidad_pedida = Convert.ToInt32(Listboxcantidad.Items[i].ToString());
                        item.Precio_producto = Convert.ToDecimal(ListboxPrecio.Items[i].ToString());
                        listadoProductos.Add(item);
                    }
                    respuesta = logicaPedido.CreaPedido(fechaventa,Convert.ToDecimal(txtTotal.Text),Usuario.Id_usuario, Convert.ToInt32(comboSocio.SelectedValue), listadoProductos,txt_orden.Text);
                    if (respuesta.ToUpper().Contains("ERROR"))
                    {
                        MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                      
                        MessageBox.Show(respuesta, "listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        this.Close();



                    }
                    }
                }
            }
        }

        private void comboSocio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DatosClientes.Clear();
                DatosClientes = logicaClientes.obtenerCliente(Convert.ToInt32(comboSocio.SelectedValue.ToString()));
                txt_Nombre.Text = DatosClientes[0].ToString();
                txt_Nit.Text = DatosClientes[1].ToString();
               


            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }
    }
}
