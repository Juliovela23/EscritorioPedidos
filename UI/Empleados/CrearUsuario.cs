using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.SeguridadLog.Commands;
using BLL.Empleados.Commands;
using BLL.Personas.Validacion;

namespace UI.Empleados
{
    public partial class CrearUsuario : Form
    {
        int generos = 0;
        CreateUsuarios logicaUsuario;
        CreateEmpleados logicEmpleados;
        ValidarPersona logicaPersona;
        public CrearUsuario()
        {
            logicaUsuario = new CreateUsuarios();
            logicEmpleados = new CreateEmpleados();
            logicaPersona = new ValidarPersona();

            InitializeComponent();
        }
        string Nombres, apellidos, telefono, direccion;
        DateTime nacimiento;
        public string Cui;

        private void ComboGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((ComboGenero.Text == "Masculino") || (ComboGenero.Text == "masculino"))
                generos = 0;
            else
                generos = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_user.Text = txt_correo.Text;
                txt_user.Enabled = false;
            }
            else
            {
                txt_user.Text = "";
                txt_user.Enabled = true;
            }
        }
        
        private void ButGuardar_Click(object sender, EventArgs e)
        {
            if (Grupo_personal.Enabled == true)
            {
                MessageBox.Show("Por favor verificar los datos personales del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((txt_user.Text == "") || (txt_pss.Text == "") || (txt_numero.Text == "") || (txt_correo.Text == "") || (txt_Cpss.Text == ""))
                {
                    MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_pss.Text == txt_Cpss.Text)
                    {

                   
                        string resp1 = logicaUsuario.VerificarUser(txt_user.Text);
                        if (resp1.ToUpper().Contains("ERROR"))
                            MessageBox.Show(resp1, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                        
                            string resp = logicEmpleados.CrearEmpleados(Nombres, apellidos,Convert.ToInt16(generos), nacimiento,Cui,telefono, direccion,1);
                            if (resp.ToUpper().Contains("ERROR"))
                            {
                                MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                int id_empleado = Convert.ToInt32(logicEmpleados.id_empleado);
                                logicaUsuario.CrearUsuarios(txt_user.Text, txt_pss.Text,txt_correo.Text,id_empleado);
                                MessageBox.Show(resp, "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                              
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
    }
}
