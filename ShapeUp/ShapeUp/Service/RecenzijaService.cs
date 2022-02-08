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
    public class RecenzijaService : BaseCRUDService<MRecenzija, RecenzijaSearchObject, Recenzija, RecenzijaInsertRequest, RecenzijaUpdateRequest>, IRecenzijaService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;
        private readonly IMentorstvoService _mentorstvoService;

        public RecenzijaService(ShapeUpDBContext context, 
                                IMapper mapper, 
                                IMentorstvoService mentorstvoService) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
            _mentorstvoService = mentorstvoService;
        }

        public override async Task<List<MRecenzija>> Get(RecenzijaSearchObject search)
        {
            var entity = _context.Set<Recenzija>().AsQueryable();

            if (search.Ocjena.HasValue)
            {
                entity = entity.Where(x => x.Ocjena == search.Ocjena);
            }
            else if (search.MentorstvoId.HasValue)
            {
                entity = entity.Where(x => x.MentorstvoId == search.MentorstvoId);
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MRecenzija>>(list);
        }

        public override async Task<MRecenzija> Insert(RecenzijaInsertRequest request)
        {
            var entity = _mapper.Map<Recenzija>(request);
            var mentorstvo = _mentorstvoService.GetById(request.MentorstvoId);

            if (mentorstvo.Result == null)
                return new MRecenzija();

            _context.Set<Recenzija>().Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MRecenzija>(entity);
        }
    }
}
