using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Ciudades.Commands;

namespace UI.Ciudades
{
    public partial class ListadoCiudad : Form
    {
        ListarCiudades logicaCiudad;
        int op = 0;
        public ListadoCiudad()
        {
            InitializeComponent();
            logicaCiudad = new ListarCiudades();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                op = 0;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    dataGridView1.DataSource = logicaCiudad.listCiudadesNombre(txtNombre.Text);
                    dataGridView1.Refresh();

                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    dataGridView1.DataSource = logicaCiudad.listCiudadesPais(txtNombre.Text);
                    dataGridView1.Refresh();

                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    dataGridView1.DataSource = logicaCiudad.listCiudadesDepartamento(txtNombre.Text);
                    dataGridView1.Refresh();

                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
              
               dataGridView1.DataSource = logicaCiudad.listCiudadesTodas();
               dataGridView1.Refresh();

                
               
            }

        }
    }
}
