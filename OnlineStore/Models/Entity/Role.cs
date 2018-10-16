using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models.Entity
{
    public class Role
    {
        public long Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}