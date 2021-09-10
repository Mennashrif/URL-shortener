using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_shortener.Data.Migrations;
using URL_shortener.Models;
using URL_shortener.NewFolder;

namespace URL_shortener.Controllers
{
    [ApiController]
    [Route("api/Urls")]
    public class URLController : Controller

    {
        private UserDbContext context;
        private readonly IRandomURL _randomURL;

        public URLController(IRandomURL randomURL)
        {
            context = new UserDbContext();
            _randomURL = randomURL;
        }

     
        [HttpPost]
        //GET/api/Urls
        public string GetUrl(URL url)
        {
            if (url.longUrl != "")
            {
                var R = new RandomURL();
                url.shortUrl = "https://localhost:44392/" + R.GetURL();
                context.Urlshortener.Add(url);
                context.SaveChanges();
                return '"' + url.shortUrl + '"';
            }
            else
            {
                url.longUrl = context.Urlshortener.Where(u => u.shortUrl == "https://localhost:44392/"+url.shortUrl).ToList()[0].longUrl;
                return '"' + url.longUrl + '"';
            }
        }
    }
}
