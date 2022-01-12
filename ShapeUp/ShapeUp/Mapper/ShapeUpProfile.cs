using AutoMapper;
using ShapeUp.Database;
using ShapeUp.Database.Models;
using ShapeUp.Dto;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Mapper
{
    public class ShapeUpProfile : Profile
    {
        public ShapeUpProfile()
        {
            CreateMap<Proizvod, MProizvodi>().ReverseMap();
            CreateMap<Trening, MTrening>().ReverseMap();
            CreateMap<TreningInsertRequest, Trening>();
            CreateMap<TreningUpdateRequest, Trening>();
            CreateMap<Cilj, MCilj>().ReverseMap();
            CreateMap<KategorijaTreninga, MKategorijaTreninga>().ReverseMap();
            CreateMap<UserRegistration, Klijent>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
           
           
    }
}
