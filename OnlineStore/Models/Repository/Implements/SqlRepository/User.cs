using OnlineStore.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public partial class SqlRepository
    {

        public IQueryable<User> Users
        {
            get
            {
                return Db.User;
            }
        }

        public bool CreateUser(User instance)
        {
            if (instance.Id == 0)
            {
                Db.User.InsertOnSubmit(instance);
                Db.User.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateUser(User instance)
        {
            User cache = Db.User.Where(p => p.Id == instance.Id).FirstOrDefault();
            if (cache != null)
            {
                cache = instance;
                Db.User.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveUser(int idUser)
        {
            User instance = Db.User.Where(p => p.Id == idUser).FirstOrDefault();
            if (instance != null)
            {
                Db.User.DeleteOnSubmit(instance);
                Db.User.Context.SubmitChanges();
                return true;
            }

            return false;
        }

    }
}