using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Reportes;
namespace UI.Reportes
{
    public partial class Reporte3 : Form
    {
        Reportes1 logicaReportes;
        public Reporte3()
        {
            logicaReportes = new Reportes1();
            InitializeComponent();
        }
        string fechaini;
        string fechafin;
        private void btnEnter_Click(object sender, EventArgs e)
        {
             fechaini = this.date1.Value.ToString("yyyy-MM-dd");
             fechafin = this.date2.Value.ToString("yyyy-MM-dd");

            
            dataGridView1.DataSource = logicaReportes.Listrep3(fechaini, fechafin);
            dataGridView1.Refresh();

           
        }

        private void butoncrear_Click(object sender, EventArgs e)
        {
            
            Rep.Formrep3 Formulario = new Rep.Formrep3();


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ClasesAux.ClassRep3 dat = new ClasesAux.ClassRep3();
                dat.FECHA = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                dat.NumPEDIDO = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                dat.Cliente = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                dat.NumPRODUCTOS = Convert.ToInt32( this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                dat.MONTO = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[4].Value.ToString());
                dat.Estado_pedido = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                dat.fI = fechaini;
                dat.fF = fechafin;
              
                Formulario.datos.Add(dat);


            }


            Formulario.ShowDialog();
        }
    }
}
