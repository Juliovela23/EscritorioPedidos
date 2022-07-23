using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL.Ciudades.Commands
{
   public class CiudadesApi
    {
        Models.Ciudades logicaCiudad;

        public CiudadesApi()
        {
            logicaCiudad = new Models.Ciudades();
        }

       public async Task consultaAsync(string ciu)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities/3315346"),
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

                    logicaCiudad.region = (string)s["data"]["region"];
                    dynamic miarray = JsonConvert.DeserializeObject(body);
                    JArray a = (JArray)s["data"];
                    //IList<Models.Ciudades> code = a.ToObject<IList<Models.Ciudades>>();

                    //foreach (var item in code)
                    //{
                    //    // Agregamos el campo nombre del archivo 'postres.json' al ComboBox 
                    //    logicaCiudad.region = item.region;

                    //}


                    //    MessageBox.Show(yourPrompt,"prueba");


                }
                response.EnsureSuccessStatusCode();



            }

        }
    }
}
