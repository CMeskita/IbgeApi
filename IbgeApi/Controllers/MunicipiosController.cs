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
        public async Task<IActionResult> Indexp()
        {

           var lista =await _service.GetUf();

            ViewBag.UF = lista;


            return View();
        }
        public async Task<IActionResult> Index(int id=23)
        {
           
            var lista = await _service.GetMunicipiosUf(id);
            //Municipios micro = new Municipios();

            //ViewBag.UF = micro;
            foreach (Municipios item in lista)
            {
                ViewBag.Municipios = item.Nome;


            }


            return View(lista);

        }
        public async Task<JsonResult> GetMicroregiaoAsync(int id=23)
        {
           
            var micro = await _service.GetMunicipiosUf(id);

            foreach (var item in micro)
            {
               // List<Municipios> lista = new List<Municipios>();
                ViewBag.MunicipiosUF= item.Id;
            }
            return (Json(micro));

        }

    }
}
