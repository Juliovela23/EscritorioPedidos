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
using System.Collections;
namespace UI.Productos.Categorias_productos
{
    public partial class EditarCategoria : Form
    {
        ListadoProductos logicalista;
        UpdateProductos logicaUpdate;
        int opcion;
        ArrayList DatosProducos = new ArrayList();
        public EditarCategoria(int op)
        {
            InitializeComponent();
            logicaUpdate = new UpdateProductos();
            logicalista = new ListadoProductos();
            opcion = op;
        }
        void CarcaCategoria()
        {
            comboBox1.DataSource = logicalista.listadoCatProducto();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "Nombre_cat";
            comboBox1.ValueMember = "Id_categoriaP";
            comboBox1.Refresh();
        }
        private void EditarCategoria_Load(object sender, EventArgs e)
        {
            CarcaCategoria();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DatosProducos.Clear();
            DatosProducos = logicalista.obtenerCategoria(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
            txt_categoria.Text = DatosProducos[0].ToString();
            txtDescripcion.Text = DatosProducos[1].ToString();
            if (opcion == 1)
            {
                butEditar.Visible = true;

            }
            else
            {
                But_eliminar.Visible = true;
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            if ((txtDescripcion.Text == "") || (txt_categoria.Text == ""))
            {


                MessageBox.Show("Por favor asegurese de llenar todos los campos");
            }
            else
            {


                try
                {
                    string res = "";
                    res = logicaUpdate.Actualizar_categoriaProducto(txt_categoria.Text, txtDescripcion.Text, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    MessageBox.Show(res);
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Error, algo salio mal");
                }

            }
        }

        private void But_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                res = logicaUpdate.DeleteC( Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                MessageBox.Show(res);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error, algo salio mal");
            }

        }
    }
}
