using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents
{
    public class SaudacaoAlunoViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var aluno = new Aluno() { Nome = "Rafael" };

            return View(aluno);
        }
    }
}
