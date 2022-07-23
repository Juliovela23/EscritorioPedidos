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
    public partial class Formrep2 : Form
    {
        public List<ClasesAux.ClassRep2> datos = new List<ClasesAux.ClassRep2>();
        public Formrep2()
        {
            InitializeComponent();
        }

        private void Formrep2_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatos", datos));
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
