using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practica04BasicMVCWebApp.Controllers
{
    public class RecetarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}