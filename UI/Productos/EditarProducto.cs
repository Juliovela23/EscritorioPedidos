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
namespace UI.Productos
{
    public partial class EditarProducto : Form
    {
        
        ArrayList DatosProductos = new ArrayList();
        ListadoProductos logicaProductos;
        UpdateProductos logicaUpdate;
        int opciones,Id_categoria;
        public EditarProducto(int op)
        {
            InitializeComponent();
            logicaProductos = new ListadoProductos();
            logicaUpdate = new UpdateProductos();
            opciones = op;
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
        void CarcaCategoria()
        {
            comboCategoria.DataSource = logicaProductos.listadoCatProducto();
            comboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCategoria.DisplayMember = "Nombre_cat";
            comboCategoria.ValueMember = "Id_categoriaP";
            comboCategoria.Refresh();
            Id_categoria = Convert.ToInt32(comboBox1.SelectedValue.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DatosProductos.Clear();
                DatosProductos = logicaProductos.obtenerProducto(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                txt_desc.Text = DatosProductos[1].ToString();
                txt_PrecioVenta.Text = DatosProductos[2].ToString();
                txt_Marca.Text = DatosProductos[3].ToString();
                txt_producto.Text = comboBox1.Text;
                Id_categoria = Convert.ToInt32(DatosProductos[4].ToString());
                if (opciones == 1)
                {
                    butEditar.Visible = true;
                }
                else
                {
                    But_eliminar.Visible = true;
                }


            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            if ((txt_desc.Text == "") || (txt_Marca.Text == "") || (txt_PrecioVenta.Text == "") || (txt_producto.Text == ""))
            {


                MessageBox.Show("Por favor asegurese de llenar todos los campos");
            }
            else
            {


                try
                {
                    string res = "";
                    res = logicaUpdate.Actualizar_producto(txt_producto.Text, txt_desc.Text, Convert.ToDecimal(txt_PrecioVenta.Text), txt_Marca.Text,Id_categoria, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
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
                res = logicaUpdate.DeleteP( Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                MessageBox.Show(res);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error, algo salio mal");
            }
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            CargaProducto();
            CarcaCategoria();
        }
    }
}
