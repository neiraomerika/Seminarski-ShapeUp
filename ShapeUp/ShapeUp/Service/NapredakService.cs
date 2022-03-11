using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Database.Models;
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
    public class NapredakService : BaseCRUDService<MNapredak, NapredakSearchObject, Napredak, NapredakInsertRequest, NapredakUpdateRequest>, INapredakService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;
        private Klijent _klijent;

        public NapredakService(ShapeUpDBContext context, 
                               IMapper mapper,
                               IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;

            if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                _klijent = _context.Users.First(x => x.UserName == httpContextAccessor.HttpContext.User.Identity.Name);
        }

        public override async Task<List<MNapredak>> Get(NapredakSearchObject search)
        {
            var entity = _context.Set<Napredak>().AsQueryable();

            if (search.KijentId != null)
            {
                entity = entity.Where(x => x.KlijentId == search.KijentId);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<MNapredak>>(list);
        }

        public override async Task<MNapredak> Insert(NapredakInsertRequest request)
        {
            if(_klijent != null)
            {
                request.KlijentId = _klijent.Id;
            }
            var entity = _mapper.Map<Napredak>(request);
            _context.Set<Napredak>().Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MNapredak>(entity);
        }
    }
}
