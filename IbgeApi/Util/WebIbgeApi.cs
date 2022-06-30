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
       
        private const string ENDPOINT = "https://servicodados.ibge.gov.br/api/v1/localidades";
        public WebIbgeApi(HttpClient http)
        {
            _http = http;
        }
        //Muncipios
        public async Task<List<Municipios>> GetMunicipios()
        {
            var response = await _http.GetStringAsync($"{ENDPOINT}/municipios");
            return JsonConvert.DeserializeObject<List<Municipios>>(response);
        }
        //Municpios por UF
        public async Task<List<Municipios>> GetMunicipiosUf(int id)
        {
            var response = await _http.GetStringAsync($"{ENDPOINT}/estados/{id}/municipios");
            return JsonConvert.DeserializeObject<List<Municipios>>(response);
        }
        //Por estados
        public async Task<List<Municipios>> GetUf()
        {
            var response = await _http.GetStringAsync($"{ENDPOINT}/estados");
            return JsonConvert.DeserializeObject<List<Municipios>>(response);
        }
        //Paises
        public async Task<List<Municipios>> GetPais()
        {
            var response = await _http.GetStringAsync($"{ENDPOINT}/paises");
            return JsonConvert.DeserializeObject<List<Municipios>>(response);
        }
    }
}
