using AutoMapper;
using ShapeUp.Database;
using ShapeUp.Model.Models;
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
            CreateMap<Proizvod, MProizvodi>();
        }
           
           
    }
}
