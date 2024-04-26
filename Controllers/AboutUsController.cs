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
    public class AboutUsController : Controller
    {
        private readonly ILogger<AboutUsController> _logger;
        private readonly ApplicationDbContext _context;


        public AboutUsController(ILogger<AboutUsController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
         /*public IActionResult PostVentas()
        {
        return View("index");
        }     */   
    }
}