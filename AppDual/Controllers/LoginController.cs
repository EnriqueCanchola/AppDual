﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoDualTese.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        
        public IActionResult Registro()
        {
            return View();
        }


      
    }
}