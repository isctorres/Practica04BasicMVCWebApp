using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica04BasicMVCWebApp.Models;

namespace Practica04BasicMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Hace referencia a la pagina Priva
        public IActionResult Privacy()
        {
            return View();
        }

        public string TestPage()
        {
            return "Saludos!!!";
        }

        public IActionResult TestPage2()
        {
            // Forma simple de enviar datos a la vista desde el controlador
            // ViewData es un array asociativo o diccionario
            ViewData["Mensaje"] = "Página que utiliza una vista sin modelo";
            return View();
        }

        public IActionResult TestPage3()
        {
            Persona ruben = new Persona {
                Nombre = "Rubensin Torres Frias",
                Edad = 35,
            };

            // Para mandar el objeto se manda como parametro
            return View(ruben);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
