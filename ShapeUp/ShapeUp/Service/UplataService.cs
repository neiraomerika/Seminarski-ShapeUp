using AutoMapper;
using ShapeUp.Database;
using ShapeUp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class UplataService : IUplataService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public UplataService(ShapeUpDBContext context,
                             IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool SetFinished(int id, bool finished)
        {
            var entity = _context.Set<Uplatum>().Find(id);
            entity.Placeno = finished;
            _context.Entry(entity).Property(x => x.Placeno).IsModified = true;
            _context.SaveChanges();
            return true;
        }

        public bool SetPaid(int id, bool paid, string chargeId)
        {
            var entity = _context.Set<Uplatum>().Find(id);
            entity.Placeno = paid;
            entity.ChargeId = chargeId;
            entity.Datum = DateTime.Now;
            _context.Entry(entity).Property(x => x.Placeno).IsModified = true;
            _context.Entry(entity).Property(x => x.ChargeId).IsModified = true;
            _context.Entry(entity).Property(x => x.Datum).IsModified = true;
            _context.SaveChanges();
            return true;
        }
    }
}
