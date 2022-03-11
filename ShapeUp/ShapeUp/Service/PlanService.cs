using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class PlanService : BaseCRUDService<MPlan, PlanSearchObject, Plan, PlanInsertRequest, PlanUpdateRequest>, IPlanService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public PlanService(ShapeUpDBContext context, IMapper mapper) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MPlan>> Get(PlanSearchObject search)
        {
            var entity = _context.Set<Plan>().AsQueryable();
            entity = entity.Include(x => x.Klijent)
                .Include(x => x.Mentorstvo)
                .Include(x => x.PlanPrehrane)
                .Include(x => x.Trening);

            if (!string.IsNullOrEmpty(search.KlijentId))
            {
                entity = entity.Where(x => x.KlijentId == search.KlijentId).OrderByDescending(x => x.Datum);
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MPlan>>(list);
        }

    }
}
