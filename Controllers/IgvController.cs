using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using igvDiazAylin.Models;

namespace igvDiazAylin.Controllers
{
    public class IgvController : Controller
    {
        private readonly ILogger<IgvController> _logger;
        public IgvController(ILogger<IgvController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(Igv objIgv)
        {
            double resultado = 0.0;
            double r = 0.0;
            
                r=Math.Round(objIgv.Operador1*0.18*100.0)/100.0;
                resultado = ((objIgv.Operador1*0.18+objIgv.Operador1)*100.0)/100.0;
          
            ViewData["Message"] = "El IGV es: " +r + " y el Total a pagar es: "+ resultado;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    
    }
}