using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_shortener.Controllers
{
    public class URLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
