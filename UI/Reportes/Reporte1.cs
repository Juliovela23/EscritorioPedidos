using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Reportes;
using BLL.Productos.Commands;
namespace UI.Reportes
{
    public partial class Reporte1 : Form
    {
        int op = 0;
        string producto;
        Reportes1 logicaReporte;
        ListadoProductos logicaProductos;
        public Reporte1()
        {
            logicaReporte = new Reportes1();
            logicaProductos = new ListadoProductos();
            InitializeComponent();
        }
        void CargaProducto()
        {
            comboBox1.DataSource = logicaProductos.listadoProducto();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "Nombre_producto";
            comboBox1.ValueMember = "Id_productos";
            comboBox1.Refresh();
        }
        string fechaini;
        string fechafin;
        private void btnEnter_Click(object sender, EventArgs e)
        {
             fechaini = this.date1.Value.ToString("yyyy-MM-dd");
             fechafin = this.date2.Value.ToString("yyyy-MM-dd");
            if (op == 0) { 
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                dataGridView1.DataSource = logicaReporte.Listrep1(comboBox1.Text, fechaini, fechafin);
                    producto = comboBox1.Text;
                    dataGridView1.Refresh();

            }
            else
                MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                producto = "Todos los productos";
                dataGridView1.DataSource = logicaReporte.ListTodoRep1( fechaini, fechafin);
                dataGridView1.Refresh();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                op = 1;
                
                comboBox1.Enabled = false;
            }
            else
            {
                op = 0;
                comboBox1.Enabled = true;
            }
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            CargaProducto();
        }

        private void butoncrear_Click(object sender, EventArgs e)
        {
            ClasesAux.ClassRep1 dat = new ClasesAux.ClassRep1();
            Rep.Formrep1 Formulario = new Rep.Formrep1();
            
                
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                


                dat.Ciudad = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                dat.NumClientes = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                dat.ProductoNombre = producto;
                dat.fI = fechaini;
                dat.fF = fechafin;
                
                Formulario.datos.Add(dat);


            }


            Formulario.ShowDialog();
        }
    }
}
