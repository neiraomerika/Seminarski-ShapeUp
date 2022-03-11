using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    public class KlijentProizvodOcjenaService : BaseCRUDService<MKlijentProizvodOcjena, KlijentProizvodOcjenaSearch, KlijentProizvodOcjena, KlijentProzivodOcjenaInsert, KlijentProizvodOcjenaUpdate>, IKlijentProizvodOcjenaService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;
        private Klijent _klijent;

        public KlijentProizvodOcjenaService(ShapeUpDBContext context,
                               IMapper mapper,
                               IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;

            if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                _klijent = _context.Users.First(x => x.UserName == httpContextAccessor.HttpContext.User.Identity.Name);
        }

        public override async Task<MKlijentProizvodOcjena> Insert(KlijentProzivodOcjenaInsert request)
        {
            if (_klijent != null)
            {
                request.KlijentId = _klijent.Id;
            }

            var entity = _mapper.Map<KlijentProizvodOcjena>(request);
            _context.Set<KlijentProizvodOcjena>().Add(entity);
            _context.SaveChanges();

            var ocjene = _context.Set<KlijentProizvodOcjena>().AsQueryable();
            ocjene = ocjene.Where(x => x.ProizvodId == request.ProizvodId);
            var proizvod = _context.Set<Proizvod>().Find(request.ProizvodId);
            if (ocjene.Any())
            {
                decimal? prosjecnaOcjena = ocjene.Average(x => x.Ocjena);

                if(proizvod != null)
                {
                    proizvod.ProsjecnaOcjena = (decimal)prosjecnaOcjena;
                    _context.Update<Proizvod>(proizvod);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                if (proizvod != null)
                {
                    proizvod.ProsjecnaOcjena = (decimal)request.Ocjena;
                    _context.Update<Proizvod>(proizvod);
                    await _context.SaveChangesAsync();
                }
            }

            return _mapper.Map<MKlijentProizvodOcjena>(entity);
        }
    }
}
