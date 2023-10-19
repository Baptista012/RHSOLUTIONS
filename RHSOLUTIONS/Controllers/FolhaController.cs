using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using PIMIVRH.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

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
