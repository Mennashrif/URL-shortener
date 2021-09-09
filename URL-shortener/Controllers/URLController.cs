using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_shortener.Data.Migrations;
using URL_shortener.Models;

namespace URL_shortener.Controllers
{
    public class URLController : Controller

    {
        private UserDbContext context;
        public URLController()
        {
            context = new UserDbContext();
        }
        [Route("UrlShortener/Add/{LongUrl}")]
        public IActionResult Add(string LongUrl)
        {
            var url = new URL();
            context.Urlshortener.Add(url);
            return View();
        }
    }
}
