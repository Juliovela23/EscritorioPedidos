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
using BLL.Ciudades.Commands;

namespace UI.Ciudades
{
    public partial class EditarCiudad : Form
    {
        CreateCiudades logicaCiudades;
        ListarCiudades logicalist;
        UpdateCiudad logicUpdate;
        int Op;
        ArrayList DatosCiudades = new ArrayList();
        public EditarCiudad(int opcion)
        {
            InitializeComponent();
            logicaCiudades = new CreateCiudades();
            logicalist = new ListarCiudades();
            logicUpdate = new UpdateCiudad();
            Op = opcion;
        }

        private void EditarCiudad_Load(object sender, EventArgs e)
        {
            CargaCiudad();
            button1.Visible = true;
        }
        void CargaCiudad()
        {
            ComboPais.DataSource = logicaCiudades.listadoCiudad();
            ComboPais.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboPais.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboPais.DisplayMember = "Nombre_Ciudad";
            ComboPais.ValueMember = "Id_ciudad";
            ComboPais.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DatosCiudades.Clear();
                DatosCiudades = logicalist.obtenerCiudad(Convert.ToInt32(ComboPais.SelectedValue.ToString()));
                txtDepartamento.Text = DatosCiudades[0].ToString();
                txtCiudad.Text = DatosCiudades[2].ToString();
                txtNivelDelmar.Text = DatosCiudades[3].ToString();
                txtRobos.Text = DatosCiudades[4].ToString();
                txt_ciud.Text = ComboPais.Text;
                txtIngresos.Text = DatosCiudades[5].ToString();
                if (Op == 1)
                {
                    butEditar.Visible = true;
                   
                }
                else
                {
                    
                }



            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {

            if ((txtCiudad.Text == "") || (txtDepartamento.Text == "") || (txtIngresos.Text == "") || (txtNivelDelmar.Text == "") || (txtRobos.Text == ""))
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string resp = logicUpdate.ActualizarCiudad(txt_ciud.Text, txtCiudad.Text, txtDepartamento.Text, txtNivelDelmar.Text, txtRobos.Text, txtIngresos.Text, Convert.ToInt32(ComboPais.SelectedValue.ToString()));
                if (resp.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resp, "Ciudad Actualizada con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
