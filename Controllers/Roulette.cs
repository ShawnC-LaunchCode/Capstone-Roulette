﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capstone_Roulette.Controllers
{
    public class Roulette : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
