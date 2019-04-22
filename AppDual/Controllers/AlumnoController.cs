using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoDualTese.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Registro_Personal_RH()
        {
            return View();
        }


        public IActionResult Publicar()
        {
            return View();
        }
    }
}