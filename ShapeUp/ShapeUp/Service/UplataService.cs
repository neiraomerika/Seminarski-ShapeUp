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

        public bool CreateUplata(int? mentorstvoId, bool paid, string chargeId, long? amount)
        {
            try
            {
                if (mentorstvoId != null)
                {
                    var mentorstvo = _context.Set<Mentorstvo>().Find(mentorstvoId);
                    var uplata = _context.Set<Uplatum>().Find(mentorstvo.UplataId);

                    if(uplata != null)
                    {
                        uplata.Placeno = paid;
                        uplata.ChargeId = chargeId;
                        _context.Update<Uplatum>(uplata);
                        _context.SaveChanges();
                    }
                }

                var entity = new Uplatum()
                {
                    Datum = DateTime.Now,
                    Iznos = decimal.Parse(amount.ToString()),
                    Placeno = paid,
                    ChargeId = chargeId
                };

                _context.Set<Uplatum>().Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;   
            }
        }
    }
}
