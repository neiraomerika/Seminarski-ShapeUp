using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class TreningService : BaseCRUDService<MTrening,TreningSearchObject,Trening,TreningInsertRequest,TreningUpdateRequest>, ITreningService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public TreningService(ShapeUpDBContext context, IMapper mapper) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MTrening>> Get(TreningSearchObject search)
        {
            var entity = _context.Set<Trening>().AsQueryable();

           if (search.KategorijaTreningaId.HasValue)
            {
                entity = entity.Where(x => x.KategorijaTreningaId == search.KategorijaTreningaId);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<MTrening>>(list);
        }

    }
}
