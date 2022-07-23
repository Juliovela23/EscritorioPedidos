using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes.Rep
{
    public partial class Formrep1 : Form
    {
        public List<ClasesAux.ClassRep1> datos = new List<ClasesAux.ClassRep1>();
        public Formrep1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formrep1_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatos", datos));
            this.reportViewer1.RefreshReport();


            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
