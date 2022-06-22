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
    }
}
