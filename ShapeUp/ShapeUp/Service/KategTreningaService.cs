using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class KategTreningaService : BaseService<MKategorijaTreninga, KategTreningaSearchObject, KategorijaTreninga>, IKategTreningaService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public KategTreningaService(ShapeUpDBContext context, IMapper mapper):base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MKategorijaTreninga>> Get(KategTreningaSearchObject search)
        {
            var entity = _context.Set<KategorijaTreninga>().AsQueryable();

            if(!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MKategorijaTreninga>>(list);
        }

        public Task<MKategorijaTreninga> GetById(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
