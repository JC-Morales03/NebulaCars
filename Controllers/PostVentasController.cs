using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NebulaCars.Models;
using NebulaCars.Data;


namespace NebulaCars.Controllers
{
    public class PostVentasController : Controller
    {
        private readonly ILogger<PostVentasController> _logger;
        private readonly ApplicationDbContext _context;


        public PostVentasController(ILogger<PostVentasController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

         public IActionResult Index()
    {
        return View();
    }

   

         public IActionResult Garantia()
        {
        return View("Garantia");
        }

         
        [HttpPost]
        public IActionResult EnviarMensaje(AgendarCitas objcita)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");

            //Se registran los datos del objeto a la base datos
            _context.Add(objcita);
            _context.SaveChanges();

            ViewData["Message"] = "Se registro el contacto";
            return View("Index");
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