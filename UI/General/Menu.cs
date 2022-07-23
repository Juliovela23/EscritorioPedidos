using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.General
{
    public partial class Menu : Form
    {
        private bool salir = true;
        BLL.SeguridadLog.Models.Login Usuario;
        public Menu(BLL.SeguridadLog.Models.Login Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Usuario.Nombres +" "+ Usuario.Apellidos;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                salir = false;
                this.Close();
                Program.frm.logout();
                Program.frm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Empleados.CrearUsuario());
        }

        private void butEmpleados_Click(object sender, EventArgs e)
        {
            
            if (panelEmpleados.Visible)
            {
                panelEmpleados.Visible = false;
                
                
            }
            else
            {
                panelEmpleados.Visible = true;
                panelClientes.Visible = false;
                panelCiudades.Visible = false;
                panelProductos.Visible = false;
                panelPedidos.Visible = false; 
                panelCategorias.Visible = false;

            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (panelClientes.Visible)
            {
                panelClientes.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = true;
                panelCiudades.Visible = false;
                panelProductos.Visible = false;
                panelPedidos.Visible = false;
                panelCategorias.Visible = false;
            }
        }

        private void panelop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Ciudades_Click(object sender, EventArgs e)
        {
            if (panelCiudades.Visible)
            {
                panelCiudades.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = false;
                panelCiudades.Visible = true;
                panelProductos.Visible = false;
                panelPedidos.Visible = false;
                panelCategorias.Visible = false;
            }

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            if (panelProductos.Visible)
            {
                panelProductos.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = false;
                panelCiudades.Visible = false;
                panelProductos.Visible = true;
                panelPedidos.Visible = false;
                panelCategorias.Visible = false;
            }
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            if (panelPedidos.Visible)
            {
                panelPedidos.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = false;
                panelCiudades.Visible = false;
                panelProductos.Visible = false;
                panelPedidos.Visible = true;
                panelCategorias.Visible = false;

            }

        }
        private Form FormularioActivo = null;
        private void abrirFormulario(Form Formhijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            Formhijo.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(Formhijo);
            panelFormularios.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Cliente.CrearCliente());
        }

        private void btn_crearCiudad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Ciudades.CrearCiudad());
        }

        private void PanelFuncion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_crearPedido_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Pedidos.CrearPedido(Usuario));
        }

        private void btn_editarPedidos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Pedidos.EditarPedido());
        }

        private void btn_listarPedidos_Click(object sender, EventArgs e)
        {

        }

        private void butCrearCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos.Categorias_productos.NuevaCategoria());

        }

        private void butEditarCategoria_Click(object sender, EventArgs e)
        {
        
        abrirFormulario(new Productos.Categorias_productos.EditarCategoria(1));

        }

    private void butListarCategorias_Click(object sender, EventArgs e)
        {

        }

        private void but_eliminarCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos.Categorias_productos.EditarCategoria(0));

        }

        private void but_Categorias_Click(object sender, EventArgs e)
        {
            if (panelCategorias.Visible)
            {
                panelCategorias.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = false;
                panelCiudades.Visible = false;
                panelProductos.Visible = false;
                panelPedidos.Visible = false;
                panelCategorias.Visible = true;
            }
        }

        private void panelPedidos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_crearProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos.CrearProductos());
        }

        private void btn_editarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Empleados.EditarEmpleado(1));
        }

        private void btn_eliminarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Empleados.EditarEmpleado(0));
        }

        private void btn_editarCliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Cliente.EsitaCliente(1));
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Cliente.EsitaCliente(0));

        }

        private void btn_editarCiudad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Ciudades.EditarCiudad(1));
        }

        private void btn_editarProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos.EditarProducto(1));

        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Productos.EditarProducto(0));
        }

        private void btn_listarClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Cliente.ListadoClientes());
        }

        private void btn_listarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Empleados.ListadoEmpleados());
        }

        private void btn_listarCiudad_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Ciudades.ListadoCiudad());
        }

        private void report1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Reportes.Reporte1());
        }

        private void Report2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Reportes.Reporte2());
        }

        private void report3_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Reportes.Reporte3());
        }

        private void report4_Click(object sender, EventArgs e)
        {

        }

        private void butReportes_Click(object sender, EventArgs e)
        {
            if (panelCiudades.Visible)
            {
               panelReportes.Visible = false;


            }
            else
            {
                panelEmpleados.Visible = false;
                panelClientes.Visible = false;
                panelCiudades.Visible = false;
                panelReportes.Visible = true;
                panelProductos.Visible = false;
                panelPedidos.Visible = false;
                panelCategorias.Visible = false;
            }
        }
    }
}
