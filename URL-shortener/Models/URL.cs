using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_shortener.Models
{
    public class URL
    {
        public int Id { get; set; } 
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
    }
}
