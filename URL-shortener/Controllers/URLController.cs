using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_shortener.Data.Migrations;
using URL_shortener.Models;

namespace URL_shortener.Controllers
{
    [ApiController]
    [Route("api/Urls")]
    public class URLController : Controller

    {
        private UserDbContext context;

        public URLController()
        {
            context = new UserDbContext();
        }

        //[HttpPost]
        ////[Route("api/[UrlShortener/Add/{LongUrl}]")]
        //public URL CreateUrl(URL url)
        //{

        //    context.Urlshortener.Add(url);
        //    context.SaveChanges();
        //    return url;

        //}
        [HttpPost]
        //GET/api/Urls
        public string GetUrl(URL url)
        {
           
            return '"'+context.Urlshortener.Where(u => u.longUrl == url.longUrl).ToList()[0].shortUrl+'"';
            
        }
    }
}
