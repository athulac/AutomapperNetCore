using AutoMapper;
using AutomapperNetCore.Models;
using AutomapperNetCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperNetCore.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(dest =>
                dest.FirstName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest =>
                dest.LastName,
                opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest =>
                dest.Email,
                opt => opt.MapFrom(src => src.Email));
        }
    }
}
