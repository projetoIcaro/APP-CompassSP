using System;
using System.Net.Http;
using System.Text;
using APPCompassSP.Model;
using Newtonsoft.Json;

namespace APPCompassSP.Layers.Service
{
    public class InvestidorService
    {
        
        public Model.InvestidorModel Get(int _id) {
            var uri = String.Format("http://APPCompassSP-webapi.azurewebsites.net/api/Investidor/{0}", _id);

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;

            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                var investidor = JsonConvert.DeserializeObject<InvestidorModel>(resultado);
                investidor.IdPerfil = investidor.PerfilInvestidor.IdPerfil;
                return investidor;
            }
            else
            {
                throw new Exception("Dados do investidor não encontrado!");
            }
        }



        public void Save(InvestidorModel _investidor) {

            var uri = String.Format("http://APPCompassSP-webapi.azurewebsites.net/api/Investidor/{0}", _investidor.IdUsuario);

            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_investidor);
            var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.PutAsync(uri,conteudoJsonString).Result;

            if ( ! resposta.IsSuccessStatusCode) {
                throw new Exception("Dados do investidor não encontrado!");
            }

        }


    }
}
