using Microsoft.AspNetCore.Mvc;
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
        //public URL CreateUrl(URL url) { 
     
        //    context.Urlshortener.Add(url);
        //    context.SaveChanges();
        //    return url;
            
        //}
        /*[HttpGet]
        //GET/api/Urls
        public IEnumerable<URL> GetUrl()
        {
            return context.Urlshortener.ToList();
        }*/
    }
}
