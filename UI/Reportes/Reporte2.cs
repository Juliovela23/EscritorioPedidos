using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Reportes;
using Newtonsoft.Json.Linq;

namespace UI.Reportes
{
    
    public partial class Reporte2 : Form
    {
        Reportes1 logicaReportes;
        int activo;
        string opciones,op;
        string idCi;
        string Hora;
        public Reporte2()
        {
            InitializeComponent();
            logicaReportes = new Reportes1();
        }
        string fechaini;
        string fechafin;
        private void btnEnter_Click(object sender, EventArgs e)
        {
             fechaini = this.date1.Value.ToString("yyyy-MM-dd");
             fechafin = this.date2.Value.ToString("yyyy-MM-dd");
            
                if ((!String.IsNullOrEmpty(comboBox1.Text))&& (!String.IsNullOrEmpty(txtCiudad.Text)))
                {
                if (activo == 1)
                {

                    if (comboBox1.Text == "Todos")
                    {
                        dataGridView1.DataSource = logicaReportes.Listrep2TodosFechas(txtCiudad.Text);
                        opciones = "Todos";
                        dataGridView1.Refresh();
                        BusquedaCiudad(txtCiudad.Text);
                        


                    }
                    else
                    {
                        dataGridView1.DataSource = logicaReportes.Listrep2SinFecha(txtCiudad.Text, comboBox1.Text);
                        opciones = comboBox1.Text;
                        dataGridView1.Refresh();
                        BusquedaCiudad(txtCiudad.Text);
                        dataGridView1.Refresh();
                    }
                }
                else
                { 
                    if (comboBox1.Text == "Todos")
                    {
                        dataGridView1.DataSource = logicaReportes.Listrep2Todos(txtCiudad.Text, fechaini, fechafin);
                        opciones = "Todos";
                        dataGridView1.Refresh();
                        BusquedaCiudad(txtCiudad.Text);
                       
                   

                    }
                    else { 
                        dataGridView1.DataSource = logicaReportes.Listrep2(txtCiudad.Text, comboBox1.Text, fechaini, fechafin);
                        opciones = comboBox1.Text;
                        dataGridView1.Refresh();
                        BusquedaCiudad(txtCiudad.Text);
                        
                    }
                 }

                }
                else
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
           
        }

        private void butoncrear_Click(object sender, EventArgs e)
        {
            ClasesAux.ClassRep2 dat = new ClasesAux.ClassRep2();
            Rep.Formrep2 Formulario = new Rep.Formrep2();


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dat.Cliente = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                dat.Telefono = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                dat.Direccion = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                dat.Estado_pedidos = opciones;
                dat.fI = fechaini;
                dat.fF = fechafin;
                dat.Ciudad = txtCiudad.Text;
                dat.Hora = Hora;
                Formulario.datos.Add(dat);


            }


            Formulario.ShowDialog();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Completado")
            {
                op = "Completado";
                opciones = "Completado";

            }
            else if (comboBox1.Text == "En proceso")
            {
                op = "En proceso";
                opciones = "En proceso";
            }
            else if (comboBox1.Text == "Anulado")
            {
                op = "Anulado";
                opciones = "Anulado";
            }
            else if (comboBox1.Text == "Todos")
            {
                opciones = "Todos";


            }

        }

        async Task BusquedaCiudad( string ciudad)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?namePrefix=" + ciudad),
                Headers =
             {
                 { "X-RapidAPI-Key", "6b89f95673msh85294dd190d1eedp1b353djsn691ab38efb63" },
                 { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
             },

            };
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string body = await response.Content.ReadAsStringAsync();


                    JObject s = JObject.Parse(body);
                    
                    idCi = (string)s["data"][0]["id"];
                    busquedaHora(idCi);



                }
                response.EnsureSuccessStatusCode();



            }

        }

        private void ChekSinF_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekSinF.Checked)
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
        }

        async Task busquedaHora(string codigo)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities/"+codigo+"/time"),
                Headers =
             {
                 { "X-RapidAPI-Key", "6b89f95673msh85294dd190d1eedp1b353djsn691ab38efb63" },
                 { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
             },

            };
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string body = await response.Content.ReadAsStringAsync();


                    JObject s = JObject.Parse(body);

                    Hora = (string)s["data"];
                    MessageBox.Show(Hora);



                }
                response.EnsureSuccessStatusCode();



            }

        }

    }
}
