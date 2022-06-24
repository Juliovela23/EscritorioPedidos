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
using BLL.Personas.Validacion;
using BLL.Empleados.Commands;
using BLL.Clientes.Commands;

namespace UI.Cliente
{
    public partial class CrearCliente : Form
    {
        CreateCiudades logicaCiudades;
        int generos = 0;
        ListarCiudades logicalist;
        ValidarPersona logicaPersona;
        CreateEmpleados logicEmpleados;
        CreateCliente logicaCliente;
        string Nombres, apellidos, telefono, direccion;
        DateTime nacimiento;
        public string Cui;
        ArrayList DatosCiudades = new ArrayList();
        public CrearCliente()
        {
            InitializeComponent();
            logicaCiudades = new CreateCiudades();
            logicalist = new ListarCiudades();
            logicEmpleados = new CreateEmpleados();
            logicaPersona = new ValidarPersona();
            logicaCliente = new CreateCliente();
        }
        private void ComboGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((ComboGenero.Text == "Masculino") || (ComboGenero.Text == "masculino"))
                generos = 0;
            else
                generos = 1;
        }
        void CargaCiudad()
        {
            ComboCiudad.DataSource = logicaCiudades.listadoCiudad();
            ComboCiudad.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboCiudad.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboCiudad.DisplayMember = "Pais";
            ComboCiudad.ValueMember = "Id_ciudad";
            ComboCiudad.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
            if (Grupo_personal.Enabled == true)
            {
                MessageBox.Show("Por favor verificar los datos personales del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((txtCiudad.Text == "") || (comboDepartamento.Text == "") || (ComboCiudad.Text == ""))
                {
                    MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    string resp = logicaCliente.CrearCliente(Nombres, apellidos, Convert.ToInt16(generos), nacimiento, Cui, telefono, direccion, Convert.ToInt32(ComboCiudad.SelectedValue.ToString()), txtNIT.Text);
                    if (resp.ToUpper().Contains("ERROR"))
                    {
                        MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show(resp, "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }




                }
            }
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {



            CargaCiudad();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DatosCiudades.Clear();
                DatosCiudades = logicalist.obtenerCiudad(Convert.ToInt32(ComboCiudad.SelectedValue.ToString()));
                comboDepartamento.Text = DatosCiudades[0].ToString();
                txtCiudad.Text = DatosCiudades[1].ToString();
                

            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        private void ButNext_Click(object sender, EventArgs e)
        {
            int validar_cui = logicaPersona.ValidarCUI(txt_cui.Text);
            int validar_nombre = logicaPersona.ValidarNombrePersona(txt_Nombre.Text);
            int validar_apellido = logicaPersona.ValidarNombrePersona(txt_Apellidos.Text);
            if ((txt_Nombre.Text == "") || (txt_Apellidos.Text == "") || (txt_cui.Text == "") || (txt_numero.Text == "") || (Txt_direccion.Text == ""))
            {
                MessageBox.Show("Por favor asegurese de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (validar_nombre != 1 || validar_apellido != 1 || validar_cui != 1)
                {
                    string resp = "";
                    if (validar_nombre != 1)
                    {
                        resp = validar_nombre == 0 ? "ERROR: El campo 'nombres' está vacío" : validar_nombre == 2 ? "ERROR: Este nombre no contiene letras" : "ERROR";
                        MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (validar_apellido != 1)
                    {
                        resp = validar_apellido == 0 ? "ERROR: El campo 'apellidos' está vacío" : validar_apellido == 2 ? "ERROR: Este apellido no contiene letras" : "ERROR";
                        MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (validar_cui != 1)
                    {
                        resp = validar_cui == 0 ? "ERROR: El 'CUI' no tiene la longitud correcta" : validar_cui == 2 ? "ERROR: Este CUI no contiene números" : "ERROR";
                        MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    resp = "";
                }
                else
                {
                    string resp = logicEmpleados.VerificarDPI(txt_cui.Text);
                    if (resp.ToUpper().Contains("ERROR"))
                        MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {

                        nacimiento = Datetimefecha.Value.Date;
                        Nombres = txt_Nombre.Text;
                        apellidos = txt_Apellidos.Text;
                        Cui = txt_cui.Text;
                        telefono = txt_numero.Text;
                        direccion = Txt_direccion.Text;
                        if (MessageBox.Show("¿Sus datos están escritos correctamente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Grupo_personal.Enabled = false;
                            GrupoUsuario.Enabled = true;
                        }
                        else
                        {
                            Grupo_personal.Enabled = true;
                            GrupoUsuario.Enabled = false;
                        }

                    }
                }
            }
        }
    }
}
