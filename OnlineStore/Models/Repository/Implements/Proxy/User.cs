using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public partial class User
    {
        public static string GetActivateUrl()
        {
            return Guid.NewGuid().ToString("N");
        }

    }
}