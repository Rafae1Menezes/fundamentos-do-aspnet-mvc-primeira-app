using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TesteEFController : Controller
    {
        public AppDbContext Db { get; set; }

        public TesteEFController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Rafael",
                Email = "rafael@gmail.com",
                DataNascimento = new DateTime(1988, 10, 07),
                Avaliacao = 5,
                Ativo = true
            };

            //Db.Alunos.Add(aluno);
            //Db.SaveChanges();

            var alunosChange = Db.Alunos.Where(a => a.Nome == "Rafael Menezes").FirstOrDefault();

            //alunosChange.Nome = "Rafael Menezes";

            //Db.Alunos.Update(alunosChange);
            //Db.SaveChanges();

            Db.Alunos.Remove(alunosChange);
            Db.SaveChanges();

            return View();
        }
    }
}
