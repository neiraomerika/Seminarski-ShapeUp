using AutoMapper;
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
        
        public virtual async Task<MMentorstvo> Insert(MentorstvoInsertRequest request)
        {
            var mentorstvo = new Mentorstvo
            {
                DatumPocetka = request.DatumPocetka,
                DatumZavrsetka = request.DatumZavrsetka,
                NazivKlijenta = request.NazivKlijenta
            };
            var uplata = new Uplatum
            {
                Datum = request.DatumUplate,
                Iznos = request.Iznos
            };

            _context.Set<Uplatum>().Add(uplata);
            _context.SaveChanges();

            mentorstvo.UplataId = uplata.Id;

            _context.Set<Mentorstvo>().Add(mentorstvo);
            await _context.SaveChangesAsync();

            return _mapper.Map<MMentorstvo>(mentorstvo);
        }
    }
}
