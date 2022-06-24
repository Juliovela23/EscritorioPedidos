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
    public partial class CrearCiudad : Form
    {
        CreateCiudades logica_ciudad;

        public CrearCiudad()
        {
            InitializeComponent();
            logica_ciudad = new CreateCiudades();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
                if ((txtCiudad.Text == "") || (txtDepartamento.Text == "") || (txtIngresos.Text == "") || (txtNivelDelmar.Text == "") || (txtRobos.Text == ""))
                {
                    MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                        string resp = logica_ciudad.CrearCiudad(txtCiudad.Text, ComboPais.Text, txtDepartamento.Text,txtNivelDelmar.Text,txtRobos.Text,txtIngresos.Text);
                        if (resp.ToUpper().Contains("ERROR"))
                        {
                            MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(resp, "Ciudad agregada con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
            
        }
    }
}
