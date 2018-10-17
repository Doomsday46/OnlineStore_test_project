using AutoMapper;
using OnlineStore.App_Data;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Mappers
{
    public class CommonMapper : IMapper
    {
        static CommonMapper()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserView>());
            Mapper.Initialize(cfg => cfg.CreateMap<UserView, User>());
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}
}