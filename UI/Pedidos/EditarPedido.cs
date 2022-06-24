using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Pedidos.Commands;
using BLL.Clientes.Commands;
using BLL.Empleados.Commands;
namespace UI.Pedidos
{
    public partial class EditarPedido : Form
    {
        ArrayList DatosClientes = new ArrayList();
        ArrayList DatosUsuarios = new ArrayList();
        ArrayList DatosPedidos = new ArrayList();
        ListadoClientes logicaClientes;
        ListarEmpleado logicaEmpleado;
        ListadoPedidos logicalista;
        UpdatePedidos logicaUpdate;
        int opciones;
        public EditarPedido()
        {
            logicalista = new ListadoPedidos();
            logicaClientes = new ListadoClientes();
            logicaEmpleado = new ListarEmpleado();
            logicaUpdate = new UpdatePedidos();
           
            InitializeComponent();
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }
        void CargaClientes()
        {
            comboBox1.DataSource = logicalista.listadoPedidos();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "Numero_de_orden";
            comboBox1.ValueMember = "Id_pedidos";
            comboBox1.Refresh();
        }
        string nombre, apellido;
        int Id_cliente;
        private void butEditar_Click(object sender, EventArgs e)
        {
            DateTime fechaventa = datePedido.Value.Date;
               if (MessageBox.Show("Está seguro del pedido?", "Proceso de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    
                    respuesta = logicaUpdate.ActualizarPedidos(fechaventa,ComboEstado.Text,Id_cliente, Convert.ToInt32(comboBox1.SelectedValue.ToString()),txt_orden.Text);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DatosPedidos.Clear();
                DatosPedidos = logicalista.obtenerPedidos(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                datePedido.Value = Convert.ToDateTime(DatosPedidos[0].ToString());
                ComboEstado.Text = DatosPedidos[1].ToString();
                txtMonto.Text = DatosPedidos[2].ToString();
                DatosClientes.Clear();
                DatosClientes = logicaClientes.obtenerCliente(Convert.ToInt32(DatosPedidos[4].ToString()));
                Id_cliente = Convert.ToInt32(DatosPedidos[4].ToString());
                txt_cliente.Text = DatosClientes[0].ToString();
                DatosUsuarios.Clear();
                DatosUsuarios = logicaEmpleado.obtenerUser(Convert.ToInt32(DatosPedidos[3].ToString()));
                nombre = DatosUsuarios[0].ToString();
                apellido = DatosUsuarios[1].ToString();
                txt_usuario.Text = nombre + " " + apellido;
                txt_orden.Text = comboBox1.Text;
                butEditar.Visible = true;
                
                




            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }
    }
}
