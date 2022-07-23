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
using BLL.Personas.Validacion;
using BLL.Empleados.Commands;
using BLL.Clientes.Commands;
using System.Collections;

namespace UI.Cliente
{
    public partial class EsitaCliente : Form
    {
        CreateCiudades logicaCiudades;
        int generos = 0;
        ListarCiudades logicalist;
        ValidarPersona logicaPersona;
        CreateEmpleados logicEmpleados;
        CreateCliente logicaCliente;
        BLL.Clientes.Commands.ListadoClientes logicaClienteslists;
        UpdateCliente logicaUpdate;
        ArrayList DatosEmpleados = new ArrayList();
        ArrayList datosClientes = new ArrayList();
        ListarEmpleado logicaEmpleados;
        DateTime nacimiento;
        int Id_persona;
        public string Cui;
        ArrayList DatosCiudades = new ArrayList();
        void CargaClientes()
        {
            comboEmpleado.DataSource = logicaClienteslists.listadoPersonas();
            comboEmpleado.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboEmpleado.DisplayMember = "Nombres";
            comboEmpleado.ValueMember = "Id_personas";
            comboEmpleado.Refresh();
        }
        private void ComboGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if ((ComboGenero.Text == "Masculino") || (ComboGenero.Text == "masculino"))
                generos = 0;
            else
                generos = 1;

        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            nacimiento = Datetimefecha.Value.Date;
            if ((txtCiudad.Text == "") || (comboDepartamento.Text == "") || (txt_numero.Text == "") )
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
             



                    string resp = logicaUpdate.Actualizar_Cliente(txt_Nombre.Text, txt_Apellidos.Text, Convert.ToInt16(generos), nacimiento, txt_cui.Text, txt_numero.Text, Txt_direccion.Text, Convert.ToInt32(comboEmpleado.SelectedValue.ToString()), 1,txtNIT.Text, Id_cliente);
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
        void CargaCiudad()
        {
            ComboCiudad.DataSource = logicaCiudades.listadoCiudad();
            ComboCiudad.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboCiudad.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboCiudad.DisplayMember = "Pais";
            ComboCiudad.ValueMember = "Id_ciudad";
            ComboCiudad.Refresh();
        }

        private void EsitaCliente_Load(object sender, EventArgs e)
        {

            CargaCiudad();
            CargaClientes();
        }

        private void ButNext_Click(object sender, EventArgs e)
        {
            GrupoUsuario.Enabled = true;
            if (Opc == 1)
            {
                butEditar.Visible = true;
            }
            else
            {
                But_eliminar.Visible = true;
            }
        }
        int id_ciudad, Id_cliente;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                datosClientes.Clear();
                datosClientes = logicaClienteslists.obtenerClienteXpersona(Convert.ToInt32(comboEmpleado.SelectedValue.ToString()));
                txt_Nombre.Text = datosClientes[2].ToString();
                txt_Apellidos.Text = datosClientes[3].ToString();
                if (datosClientes[4].ToString() == "1")
                {
                    ComboGenero.Text = "Masculino";

                }
                else
                {
                    ComboGenero.Text = "Femenino";
                }
                Txt_direccion.Text = datosClientes[5].ToString();
                txt_numero.Text = datosClientes[0].ToString();
                txt_cui.Text = datosClientes[6].ToString();

                Id_cliente = Convert.ToInt32(datosClientes[8].ToString());


                txtNIT.Text = datosClientes[1].ToString();
                id_ciudad= Convert.ToInt32(datosClientes[7].ToString());
                try
                {
                    DatosCiudades.Clear();
                    DatosCiudades = logicalist.obtenerCiudad(Convert.ToInt32(id_ciudad));
                    comboDepartamento.Text = DatosCiudades[0].ToString();
                    txtCiudad.Text = DatosCiudades[1].ToString();


                }
                catch
                {

                    MessageBox.Show("se encontro un error");
                }


            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }

        int Opc;
        public EsitaCliente(int opcion)
        {
            InitializeComponent();
            logicaCiudades = new CreateCiudades();
            logicalist = new ListarCiudades();
            logicEmpleados = new CreateEmpleados();
            logicaPersona = new ValidarPersona();
            logicaCliente = new CreateCliente();
            logicaEmpleados = new ListarEmpleado();
            logicaClienteslists = new BLL.Clientes.Commands.ListadoClientes();
            logicaUpdate = new UpdateCliente();
            Opc = opcion;
        }

        private void But_eliminar_Click(object sender, EventArgs e)
        {
            nacimiento = Datetimefecha.Value.Date;
            if ((txtCiudad.Text == "") || (comboDepartamento.Text == "") || (txt_numero.Text == ""))
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {




                string resp = logicaUpdate.Actualizar_Cliente(txt_Nombre.Text, txt_Apellidos.Text, Convert.ToInt16(generos), nacimiento, txt_cui.Text, txt_numero.Text, Txt_direccion.Text, Convert.ToInt32(comboEmpleado.SelectedValue.ToString()), 0, txtNIT.Text, Id_cliente);
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

        private void ComboCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
