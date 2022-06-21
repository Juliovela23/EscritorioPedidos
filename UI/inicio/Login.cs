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
using BLL.SeguridadLog.Models;
namespace UI.inicio
{
    public partial class Login : Form
    {
        
       BLL.SeguridadLog.Commands.Login logicaInicio;
        public Login()
        {
            InitializeComponent();
            logicaInicio = new BLL.SeguridadLog.Commands.Login();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpss.Text = "";
            
            txtuser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpss.Text) || String.IsNullOrEmpty(txtuser.Text))
                MessageBox.Show("Por favor llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
               
                    
                    BLL.SeguridadLog.Models.Login Usuario;
                    Usuario = logicaInicio.Inicio(txtuser.Text, txtpss.Text);
                    if (Usuario.Validate == false)
                    {
                        MessageBox.Show("Credenciales inválidas, inténtalo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    else
                    {
                        this.Hide();
                        UI.Form1 frm = new UI.Form1(Usuario);
                        
                        frm.Show();
                    }

                
            }
        }
    }
}
