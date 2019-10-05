using System;
using System.Collections.Generic;
using System.Net.Http;
using APPCompassSP.Model;
using Newtonsoft.Json;

namespace APPCompassSP.Layers.Service
{
    public class PerfilService
    {
        public IList<PerfilModel> Get() {
            var uri = "http://APPCompassSP-webapi.azurewebsites.net/api/Perfil/";

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var perfis = JsonConvert.DeserializeObject<IList<PerfilModel>>(resultado);
                return perfis;
            }
            else
            {
                throw new Exception("Perfis não encontrados!");
            }

        }
    }
}
