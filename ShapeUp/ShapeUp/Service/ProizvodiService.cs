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
    public class ProizvodiService : BaseCRUDService<MProizvodi,Proizvod,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>, IProizvodiService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper mapper;
        public ProizvodiService(ShapeUpDBContext context,IMapper mapper):base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }

       
        public override async Task<List<MProizvodi>> Get(ProizvodiSearchObject search)
        {
            var entity = _context.Set<Proizvod>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.KategorijaProizvodaId.HasValue)
            {
                entity = entity.Where(x => x.KategorijaProizvodaId == search.KategorijaProizvodaId);
            }
            var list = await entity.ToListAsync();
            return _mapper.Map<List<MProizvodi>>(list);
        }

    }
}
