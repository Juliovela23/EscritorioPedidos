using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.General
{
    public partial class Menu : Form
    {
        BLL.SeguridadLog.Models.Login Usuario;
        public Menu(BLL.SeguridadLog.Models.Login Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
