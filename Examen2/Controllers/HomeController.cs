using Examen2.Models;
using Examen2.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Examen2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiciosEmail serviciosEmail;
        private readonly IServicioEncuesta servicioEncuesta;

        public HomeController(ILogger<HomeController> logger, IServiciosEmail serviciosEmail, IServicioEncuesta servicioEncuesta)
        {
            _logger = logger;
            this.serviciosEmail = serviciosEmail;
            this.servicioEncuesta = servicioEncuesta;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ResultadosViewModel model, EncuestaViewModel encuesta)
        {
            _logger.LogInformation("Nombre: " + model.Nombre);
            string puntuacion = servicioEncuesta.Puntuacion(encuesta);
            _logger.LogInformation(puntuacion);

            await serviciosEmail.Enviar(model, puntuacion);
            return RedirectToAction("Exito");
            
        }

        public IActionResult Exito(EncuestaViewModel modelo)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}