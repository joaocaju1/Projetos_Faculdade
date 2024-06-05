using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class CarrosController : Controller
    {
        private readonly List<Carros> carro = new List<Carros>();

        public CarrosController()
        {
            carro.Add(new Carros()
            { 
                Carro = "Argo",
                Marca = "Fiat",
                Valor = "R$: 120000"           
            });

            carro.Add(new Carros()
            {
                Carro = "Uno 2023",
                Marca = "Fiat",
                Valor = "R$: 100000"
            });
        }
        public IActionResult Index()
        {
            return View(carro);
        }

        public IActionResult Details(string id)
        {
            var modelo = carro.Find(a => a.Valor == id);
            if (modelo == null) return NotFound();
            return View(modelo);
        }
    }
}
