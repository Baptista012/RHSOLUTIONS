﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMIVRH.Controllers
{
    public class FolhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
