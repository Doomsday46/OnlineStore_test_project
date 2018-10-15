using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineStore.Models.service;

namespace OnlineStore.Models
{
    public class DBInitialazer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {

            context.Phones.Add(new Phone() { Type = "Xiaomi redmi 4 pro", Price = 15000, Produce = "Xiaomi" });

            base.Seed(context);
        }
    }
}