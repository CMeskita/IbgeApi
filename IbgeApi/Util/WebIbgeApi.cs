using IbgeApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Servicos.Util
{
    public class WebIbgeApi : IWebIbgeApi
    {
        HttpClient _http;
        private const string ENDPOINT = "https://servicodados.ibge.gov.br/api/v1/localidades/municipios";

        public WebIbgeApi(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Municipios>> GetMunicipios()
        {
            var response = await _http.GetStringAsync($"{ENDPOINT}");
            var num= JsonConvert.DeserializeObject<List<Municipios>>(response);
            return num;

           


          



        }

    }
}
