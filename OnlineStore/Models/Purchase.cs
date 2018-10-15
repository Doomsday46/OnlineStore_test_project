using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Purchase
    {
        public long Id { get; set; }
        public long IdPhone { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

    }
}