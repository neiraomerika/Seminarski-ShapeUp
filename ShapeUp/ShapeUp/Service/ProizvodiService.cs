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
    public class ProizvodiService : BaseCRUDService<MProizvodi, ProizvodiSearchObject, Proizvod,ProizvodiInsertRequest,ProizvodiUpdateRequest>, IProizvodiService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;
        public ProizvodiService(ShapeUpDBContext context, IMapper mapper): base(context, mapper)
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
            var recommended = Recommend(entity);
            var list = recommended.ToList();
            return _mapper.Map<List<MProizvodi>>(list);
        }

        public IEnumerable<Proizvod> Recommend(IQueryable<Proizvod> proizvodi)
        {
            var ocjeneProizvoda = new List<Tuple<decimal, Proizvod>>();
            foreach (var item in proizvodi)
            {
                ocjeneProizvoda.Add(Tuple.Create(item.ProsjecnaOcjena, item));
            }
            ocjeneProizvoda = ocjeneProizvoda.OrderByDescending(x => x.Item1).ToList();
            var list = ocjeneProizvoda.Select(x => x.Item2);
            return list;
        }

    }
}
