using System;
using AutoMapper;
using Macintosh_OOP.Models;

namespace Macintosh_OOP.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Account, UserModel>();
            CreateMap<RegisterModel, Account>();
        }
    }
}
