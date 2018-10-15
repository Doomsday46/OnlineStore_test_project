using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Phone
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Produce { get; set; }
        public int Price { get; set; }

    }
}