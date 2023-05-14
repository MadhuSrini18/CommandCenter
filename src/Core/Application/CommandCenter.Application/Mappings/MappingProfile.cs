using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CommandCenter.Application.Dtos;
using CommandCenter.Domain.Entities;

namespace CommandCenter.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<UsersDto, Users>().ReverseMap();
        }
    }
}
