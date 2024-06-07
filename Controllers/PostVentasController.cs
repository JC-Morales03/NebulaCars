using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NebulaCars.Models;
using NebulaCars.Data;
using NebulaCars.Service;


namespace NebulaCars.Controllers
{
    public class PostVentasController : Controller
    {
        private readonly ILogger<PostVentasController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly PostVentasService _postventasService;

        public PostVentasController(ILogger<PostVentasController> logger,ApplicationDbContext context,PostVentasService postVentasService)
        {
            _logger = logger;
            _context = context;
            _postventasService=postVentasService;
        }

         public IActionResult Index()
    {
        return View();
    }
         public async Task<IActionResult> Citas()
        {
            var AgendarCitas = await _postventasService.GetAllAgendarCitas();
            return View(AgendarCitas);
        }
   

         public IActionResult Garantia()
        {
        return View("Garantia");
        }

         
        [HttpPost]
        public IActionResult EnviarCita(AgendarCitas objcita)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");
            // Convertir las fechas a UTC
             objcita.ConvertToUtc();
            //Se registran los datos del objeto a la base datos
            _context.Add(objcita);
            _context.SaveChanges();

            ViewData["Message"] = "Se registro su cita";
            return View("Agendar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

         public IActionResult PostVentas()
        {
        return View("index");
        }   
     
    
     public IActionResult Agendar()
    {
        return View("Agendar");
    }
    }
}