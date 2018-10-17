﻿using OnlineStore.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public partial class SqlRepository
    {

        public IQueryable<Role> Roles
        {
            get
            {
                return Db.Role;
            }
        }

        public bool CreateRole(Role instance)
        {
            if (instance.Id == 0)
            {
                Db.Role.InsertOnSubmit(instance);
                Db.Role.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateRole(Role instance)
        {
            Role cache = Db.Role.Where(p => p.Id == instance.Id).FirstOrDefault();
            if (cache != null)
            {
                cache = instance;
                Db.Role.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveRole(int idRole)
        {
            Role instance = Db.Role.FirstOrDefault(p => p.Id == idRole);
            if (instance != null)
            {
                Db.Role.DeleteOnSubmit(instance);
                Db.Role.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}