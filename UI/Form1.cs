using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        BLL.SeguridadLog.Models.Login Usuario;
        public Form1(BLL.SeguridadLog.Models.Login Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBV.Text = "";
            lblEstado.Text = "Estamos preparando todo";

            if (Usuario.Genero == 0)
                lblBV.Text = "Bienvenida";
            else
                lblBV.Text = "Bienvenido";
            lblUsuario.Text = Usuario.Usuario;

            this.Opacity = 0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                lblEstado.Text = "LISTO";
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                UI.General.Menu frm = new UI.General.Menu(Usuario);
                frm.Show();
            }
        }
    }
}
