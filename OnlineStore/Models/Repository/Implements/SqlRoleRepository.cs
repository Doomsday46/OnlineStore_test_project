using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using OnlineStore.Models.Entity;

namespace OnlineStore.Models.Repository.Implements
{
    public class SqlRoleRepository : IRoleRepository
    {
        [Inject]
        public AuthDB Db { get; set; }
        public IQueryable<Role> Roles
        {
            get
            {
                return Db.Roles;
            }
        }

        public bool CreateRole(Role instance)
        {
            if (instance.Id == 0)
            {
                Db.Roles.InsertOnSubmit(instance);
                Db.Roles.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveRole(int idRole)
        {
            Role instance = Db.Roles.FirstOrDefault(p => p.ID == idRole);
            if (instance != null)
            {
                Db.Roles.DeleteOnSubmit(instance);
                Db.Roles.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateRole(Role instance) {
            if (instance != null)
            {
                Db.Roles.InsertOnSumbit(instance);
                Db.Roles.Context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}