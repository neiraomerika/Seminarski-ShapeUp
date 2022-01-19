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
    public class TreningService : BaseCRUDService<MTrening,TreningSearchObject, Database.Trening,TreningInsertRequest,TreningUpdateRequest>, ITreningService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public TreningService(ShapeUpDBContext context, IMapper mapper) :base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Models.MTrening>> Get(TreningSearchObject search)
        {
            var entity = _context.Set<Database.Trening>().AsQueryable();

           if (search.Id.HasValue)
            {
                entity = entity.Where(x => x.KategorijaTreningaId == search.Id);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<Model.Models.MTrening>>(list);
        }

    }
}
