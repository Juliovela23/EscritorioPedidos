using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Clientes.Commands;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using BLL.Ciudades.Models;
using BLL.Ciudades.Commands;
using System.Collections;

namespace UI.Cliente
{
    public partial class ListadoClientes : Form
    {
        int op = 0;
        CiudadesApi logicaCiudad;
        BLL.Ciudades.Models.Ciudades ciudad;
        BLL.Clientes.Commands.ListadoClientes logicaClientes;
        ArrayList DatosCiudades = new ArrayList();
        public ListadoClientes()
        {
            logicaClientes = new BLL.Clientes.Commands.ListadoClientes();
            logicaCiudad = new CiudadesApi();
            ciudad = new BLL.Ciudades.Models.Ciudades();
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    dataGridView1.DataSource = logicaClientes.listClientes(txtNombre.Text);
                    dataGridView1.Refresh();
                   
                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    dataGridView1.DataSource = logicaClientes.listadoClientesNIT(txtNombre.Text);
                    dataGridView1.Refresh();

                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbDir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDir.Checked)
            {
                op = 1;
            }
            else
            {
                op = 0;
            }
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaClientes.TodosClientes();
            dataGridView1.Refresh();



        }


    }
}
