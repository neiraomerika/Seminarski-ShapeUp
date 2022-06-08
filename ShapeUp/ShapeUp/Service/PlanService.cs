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
        private UserManager<Klijent> _userManager;

        public PlanService(ShapeUpDBContext context, 
                           IMapper mapper,
                           IHttpContextAccessor httpContextAccessor,
                           UserManager<Klijent> userManager) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;

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

            if (_klijent != null)
            {
                var role = _userManager.GetRolesAsync(_klijent);
                if (role.Result.Count != 0)
                {
                    bool isAdmin = false;
                    bool isKlijent = false;

                    foreach (var item in role.Result)
                    {
                        if (item == "Administrator")
                            isAdmin = true;
                        if (item == "Klijent")
                            isKlijent = true;
                    }
                    if (isAdmin)
                    {
                        if (!string.IsNullOrEmpty(search.KlijentId))
                        {
                            entity = entity.Where(x => x.KlijentId == search.KlijentId).OrderByDescending(x => x.Datum);
                        }
                    }
                    else if (isKlijent)
                    {
                        entity = entity.Where(x => x.KlijentId == _klijent.Id);
                    }
                }
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MPlan>>(list);
        }

    }
}
