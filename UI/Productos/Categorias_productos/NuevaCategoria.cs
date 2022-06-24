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
namespace UI.Productos.Categorias_productos
{
    public partial class NuevaCategoria : Form
    {
        CreateProducto logicaProducto;
        public NuevaCategoria()
        {
            logicaProducto = new CreateProducto();
            InitializeComponent();
        }

        private void but_agregar_Click(object sender, EventArgs e)
        {
            if ((txtDescripcion.Text == "") || (txt_categoria.Text == "") )
            {


                MessageBox.Show("Por favor asegurese de llenar todos los campos");
            }
            else
            {


                try
                {
                    string res = "";
                    res = logicaProducto.CrearCATProducto(txt_categoria.Text, txtDescripcion.Text);
                    MessageBox.Show(res);
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Error, algo salio mal");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
