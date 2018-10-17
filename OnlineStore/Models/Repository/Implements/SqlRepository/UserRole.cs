using OnlineStore.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public partial class SqlRepository
    {

        public IQueryable<UserRole> UserRoles
        {
            get
            {
                return Db.UserRole;
            }
        }

        public bool CreateUserRole(UserRole instance)
        {
            if (instance.Id == 0)
            {
                Db.UserRole.InsertOnSubmit(instance);
                Db.UserRole.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateUserRole(UserRole instance)
        {
            UserRole cache = Db.UserRole.Where(p => p.Id == instance.Id).FirstOrDefault();
            if (cache != null)
            {
                cache = instance;
                Db.UserRole.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveUserRole(int idUserRole)
        {
            UserRole instance = Db.UserRole.Where(p => p.Id == idUserRole).FirstOrDefault();
            if (instance != null)
            {
                Db.UserRole.DeleteOnSubmit(instance);
                Db.UserRole.Context.SubmitChanges();
                return true;
            }

            return false;
        }

    }
}