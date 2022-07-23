using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Empleados.Commands;
namespace UI.Empleados
{
    public partial class ListadoEmpleados : Form
    {
        ListarEmpleado logicaEmpleados;
        public ListadoEmpleados()
        {
            logicaEmpleados = new ListarEmpleado();
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                dataGridView1.DataSource = logicaEmpleados.listEmpleados(txtNombre.Text);
                dataGridView1.Refresh();

            }
            else
                MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaEmpleados.TodosEmpleados();
            dataGridView1.Refresh();
        }
    }
}
