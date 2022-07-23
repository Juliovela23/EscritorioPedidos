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
    public partial class Formrep3 : Form
    {
        public List<ClasesAux.ClassRep3> datos = new List<ClasesAux.ClassRep3>();
        public Formrep3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formrep3_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatos", datos));
            this.reportViewer1.RefreshReport();
        }
    }
}
