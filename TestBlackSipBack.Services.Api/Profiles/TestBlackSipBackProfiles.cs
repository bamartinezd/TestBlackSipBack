using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlackSipBack.Domain.Entities;
using TestBlackSipBack.Services.Dto;

namespace TestBlackSipBack.Services.Api.Profiles
{
    public class TestBlackSipBackProfiles : Profile
    {
        public TestBlackSipBackProfiles() {
            this.CreateMap<Registro, RegistroDTO>().ReverseMap();
            this.CreateMap<MenuItem, MenuItemDTO>().ReverseMap();
        }
    }
}
