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
    public class KategProizvodaService : BaseService<MKategorijaProizvodum, KategProizvodaSearchObject, KategorijaProizvodum>, IKategorijaProizvodaService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public KategProizvodaService(ShapeUpDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MKategorijaProizvodum>> Get(KategProizvodaSearchObject search)
        {
            var entity = _context.Set<KategorijaProizvodum>().AsQueryable();

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                entity = entity.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            var list = await entity.ToListAsync();
            return _mapper.Map<List<MKategorijaProizvodum>>(list);
        }
    }
}
