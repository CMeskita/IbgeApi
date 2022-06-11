using IbgeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Servicos.Util;
using System.Threading.Tasks;

namespace IbgeApi.Controllers
{
    public class MunicipiosController : Controller
    {

        private readonly IWebIbgeApi _service;

        public MunicipiosController(IWebIbgeApi service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
           var lista = await _service.GetMunicipios();



            foreach (Municipios item in lista)
            {
                ViewBag.Municipios = item.Nome;
            }

            return View(lista);

        }
        public async Task<JsonResult> GetMicroregiaoAsync()
        {
            var micro = await _service.GetMunicipios();

           // List<Municipios> micro = new List<Municipios>();
            foreach (Municipios item in micro)
            {
                ViewBag.Municipios = item.MicroRegiao.Id;
            }
            return Json(micro);

        }

    }
}
