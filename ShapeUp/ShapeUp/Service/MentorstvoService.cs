﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class MentorstvoService : BaseCRUDService<MMentorstvo, MentorstvoSearchObject, Mentorstvo, MentorstvoInsertRequest, MentorstvoUpdateRequest>, IMentorstvoService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public MentorstvoService(ShapeUpDBContext context, IMapper mapper):base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MMentorstvo>> Get(MentorstvoSearchObject search)
        {
            var entity = _context.Set<Mentorstvo>().AsQueryable();
            entity = entity.Include(x => x.Uplata);

            if (!string.IsNullOrEmpty(search.Klijent))
            {
                entity = entity.Where(x => x.NazivKlijenta.Contains(search.Klijent));
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MMentorstvo>>(list);
        }
    }
}
