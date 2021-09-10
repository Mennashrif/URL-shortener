using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_shortener.Models
{
    public class URL
    {
        public int id { get; set; }
        public string longUrl { get; set; }
        public string shortUrl { get; set; }
    }
}
