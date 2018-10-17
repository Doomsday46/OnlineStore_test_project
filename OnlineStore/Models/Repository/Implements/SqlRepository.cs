using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using OnlineStore.App_Data;

namespace OnlineStore.Models
    public partial class SqlRepository : IRepository
    {
        [Inject]
        public AuthDBDataContext Db { get; set; }

    }
}