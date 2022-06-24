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
using BLL.Empleados.Commands;

namespace UI.Empleados
{
    public partial class EditarEmpleado : Form
    {
        ArrayList DatosEmpleados = new ArrayList();
        int Opcion;
        ListarEmpleado logicaEmpleados;
        UpdateEmpleado logicaUpdate;
        int Id_empleado, Id_usuario, Id_persona;
        public EditarEmpleado(int opcion)
        {
            InitializeComponent();
            logicaEmpleados = new ListarEmpleado();
            logicaUpdate = new UpdateEmpleado();
            Opcion = opcion;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            CargaEmpleados();
        }
        void CargaEmpleados()
        {
            comboEmpleado.DataSource = logicaEmpleados.listadoPersonas();
            comboEmpleado.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboEmpleado.DisplayMember = "Nombres";
            comboEmpleado.ValueMember = "Id_personas";
            comboEmpleado.Refresh();
        }
        DateTime nacimiento;
        private void butEditar_Click(object sender, EventArgs e)
        {
         

                if ((txt_user.Text == "") || (txt_pss.Text == "") || (txt_numero.Text == "") || (txt_correo.Text == "") || (txt_Cpss.Text == ""))
                {
                    MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_pss.Text == txt_Cpss.Text)
                    {
                        nacimiento = Datetimefecha.Value.Date;



                        string resp = logicaUpdate.Actualizar_Empleado(txtNombre.Text,txt_Apellidos.Text, Convert.ToInt16(generos), nacimiento,txt_cui.Text,txt_numero.Text,Txt_direccion.Text,Id_persona,1,Id_empleado,txt_user.Text,txt_pss.Text,txt_correo.Text,Id_usuario);
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
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        int generos;
        private void ComboGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((ComboGenero.Text == "Masculino") || (ComboGenero.Text == "masculino"))
                generos = 0;
            else
                generos = 1;
        }

        private void But_eliminar_Click(object sender, EventArgs e)
        {
            if ((txt_user.Text == "") || (txt_pss.Text == "") || (txt_numero.Text == "") || (txt_correo.Text == "") || (txt_Cpss.Text == ""))
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nacimiento = Datetimefecha.Value.Date;

                string resp = logicaUpdate.Actualizar_Empleado(txtNombre.Text, txt_Apellidos.Text, Convert.ToInt16(generos), nacimiento, txt_cui.Text, txt_numero.Text, Txt_direccion.Text, Id_persona, 0, Id_empleado, txt_user.Text, txt_pss.Text, txt_correo.Text, Id_usuario);
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

        private void ButNext_Click(object sender, EventArgs e)
        {
            GrupoUsuario.Enabled = true;
            if (Opcion == 1)
            {
                butEditar.Visible = true;
            }
            else
            {
                But_eliminar.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DatosEmpleados.Clear();
                DatosEmpleados = logicaEmpleados.obtenerCliente(Convert.ToInt32(comboEmpleado.SelectedValue.ToString()));
                txtNombre.Text = DatosEmpleados[0].ToString();
                txt_Apellidos.Text = DatosEmpleados[1].ToString();
                if (DatosEmpleados[2].ToString() == "1")
                {
                    ComboGenero.Text = "Masculino";

                }
                else
                {
                    ComboGenero.Text = "Femenino";
                }
                Txt_direccion.Text = DatosEmpleados[3].ToString();
                txt_numero.Text = DatosEmpleados[4].ToString();
                txt_cui.Text = DatosEmpleados[5].ToString();
                txt_user.Text = DatosEmpleados[6].ToString();

                txt_correo.Text = DatosEmpleados[7].ToString();
                txt_pss.Text = DatosEmpleados[8].ToString();
                txt_Cpss.Text = DatosEmpleados[8].ToString();
                Id_empleado = Convert.ToInt32(DatosEmpleados[9].ToString());
                Id_usuario = Convert.ToInt32(DatosEmpleados[11].ToString());
                Id_persona = Convert.ToInt32(DatosEmpleados[10].ToString());




            }
            catch
            {

                MessageBox.Show("se encontro un error");
            }
        }
    }
}
