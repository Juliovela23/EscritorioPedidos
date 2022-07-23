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
using BLL.Ciudades.Commands;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UI.Ciudades
{
    public partial class CrearCiudad : Form
    {
        CreateCiudades logica_ciudad;
        string CodigoPais,nameCiudad,idCi;
        public CrearCiudad()
        {
            InitializeComponent();
            logica_ciudad = new CreateCiudades();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if((txtPais.Text==" ") && (txtCiudadBus.Text == ""))
            {
                MessageBox.Show("Por favor llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            { 
                BusquedaPais(txtPais.Text);
            
            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
                if ((txtCiudad.Text == "") || (txtDepartamento.Text == "") || (txtIngresos.Text == "") || (txtNivelDelmar.Text == "") || (txtRobos.Text == ""))
                {
                    MessageBox.Show("Asegurese de llenar todos los campos", "Erro: Hay algun campo vacior", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                        string resp = logica_ciudad.CrearCiudad(txtCiudad.Text, txtPais.Text, txtDepartamento.Text,txtNivelDelmar.Text,txtRobos.Text,txtIngresos.Text);
                        if (resp.ToUpper().Contains("ERROR"))
                        {
                            MessageBox.Show(resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(resp, "Ciudad agregada con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
            
        }

        #region API

        async Task BusquedaCiudadDetalles(string IdCiudad)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities/"+IdCiudad),
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
                    txtDepartamento.Text = (string)s["data"]["region"];
                    txtCiudad.Text = (string)s["data"]["name"];
                    txtNivelDelmar.Text= (string)s["data"]["elevationMeters"];



                }
                response.EnsureSuccessStatusCode();



            }

        }


        async Task BusquedaPais(string pais)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?namePrefix="+pais),
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
                    CodigoPais = (string)s["data"][0]["code"];
                    BusquedaCiudad(CodigoPais, txtCiudadBus.Text);
                   
                }
                response.EnsureSuccessStatusCode();



            }

        }

        async Task BusquedaCiudad(string c, string ciudad)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?countryIds="+c+"&namePrefix="+ciudad),
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
                    nameCiudad = (string)s["data"][0]["name"];
                    idCi = (string)s["data"][0]["id"];
                    BusquedaCiudadDetalles(idCi);



                }
                response.EnsureSuccessStatusCode();



            }

        }
        #endregion
    }
}
