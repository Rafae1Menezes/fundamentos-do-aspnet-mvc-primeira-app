using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    [Route("minha-conta")]
    public class TestesController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("detalhes/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpGet("novo")]
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("editar/{id:int}")]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost("editar/{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("excluir/{id:int}")]
        public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost("excluir/{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
