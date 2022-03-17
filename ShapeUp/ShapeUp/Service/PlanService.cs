using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Database.Models;
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
        private Klijent _klijent;
        private UserManager<Klijent> userManager;

        public PlanService(ShapeUpDBContext context, 
                           IMapper mapper,
                           IHttpContextAccessor httpContextAccessor,
                           UserManager<Klijent> _userManager) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
            userManager = _userManager;

            if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                _klijent = _context.Users.First(x => x.UserName == httpContextAccessor.HttpContext.User.Identity.Name);
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

            if (list.Count != 0)
                return _mapper.Map<List<MPlan>>(list); 
            else
                return new List<MPlan>();
        }

    }
}
