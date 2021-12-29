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
    public class CiljService : BaseService<MCilj, CiljSearchObject, Cilj>, ICiljService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public CiljService(ShapeUpDBContext context, IMapper mapper):base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MCilj>> Get(CiljSearchObject search)
        {
            var entity = _context.Set<Cilj>().AsQueryable();

            if(!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MCilj>>(list);
        }

        public Task<MCilj> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
