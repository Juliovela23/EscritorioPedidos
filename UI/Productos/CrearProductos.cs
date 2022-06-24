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
using BLL.Productos.Commands;
namespace UI.Productos
{
    public partial class CrearProductos : Form
    {
        ListadoProductos logicalista;
        CreateProducto logicacrearProducto;
        ArrayList DatosProducos = new ArrayList();
        public CrearProductos()
        {
            logicalista = new ListadoProductos();
            logicacrearProducto = new CreateProducto();
            InitializeComponent();
        }
        void CarcaCategoria()
        {
            comboCategoria.DataSource = logicalista.listadoCatProducto();
            comboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCategoria.DisplayMember = "Nombre_cat";
            comboCategoria.ValueMember = "Id_categoriaP";
            comboCategoria.Refresh();
        }
        private void CrearProductos_Load(object sender, EventArgs e)
        {
            CarcaCategoria();

        }

        private void but_agregar_Click(object sender, EventArgs e)
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
                        res = logicacrearProducto.CrearProducto(txt_producto.Text, txt_desc.Text,Convert.ToDecimal(txt_PrecioVenta.Text),txt_Marca.Text, Convert.ToInt32(comboCategoria.SelectedValue.ToString()));
                        MessageBox.Show(res);
                        this.Close();

                }
                    catch
                    {
                        MessageBox.Show("Error, algo salio mal");
                    }
                
            }
        }

        private void comboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DatosProducos.Clear();
                DatosProducos = logicalista.obtenerCategoria(Convert.ToInt32(comboCategoria.SelectedValue.ToString()));
                


            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
