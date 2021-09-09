using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_shortener.Models
{
    public class URL
    {
        private int _id { get; set; } 
        private string _longUrl { get; set; }
        private string _shortUrl { get; set; }
    }
}
