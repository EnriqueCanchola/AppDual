using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace AppDual.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            List<ML.Alumno> listaAlumno = new List<ML.Alumno>();


            return View(listaAlumno);

        }
    }
}