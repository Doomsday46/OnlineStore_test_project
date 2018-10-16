using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore.Models.Entity;

namespace OnlineStore.Models
{
    public interface IRoleRepository
    {
        IQueryable<Role> Roles { get; }

        bool CreateRole(Role instance);

        bool UpdateRole(Role instance);

        bool RemoveRole(int idRole);
    }
}