using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Database.Models;
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
    public class KlijentService : IKlijentService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public KlijentService(ShapeUpDBContext context,
                              IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<MKlijent>> Get(KlijentSearchObject search)
        {
            var klijenti = _context.Set<Klijent>().AsQueryable();

            var signUps = _context.Set<Prijava>().AsQueryable();

            var mentorshipPlans = _context.Set<Plan>().AsQueryable()
                .Include(x => x.Mentorstvo)
                .Include(x => x.Mentorstvo).ThenInclude(x => x.Uplata);

            if (!string.IsNullOrEmpty(search.FirstnameLastname))
            {
                klijenti = klijenti.Where(x => (x.FirstName.ToLower() + ' ' + x.LastName.ToLower()).Contains(search.FirstnameLastname.ToLower()));
            }
            var list = await klijenti.ToListAsync();
            var mappedList = _mapper.Map<List<MKlijent>>(list);
            var mappedPlan = _mapper.Map<List<MPlan>>(mentorshipPlans).AsQueryable();

            foreach (MKlijent klijent in mappedList)
            {
                foreach (Prijava prijava in signUps)
                {
                    if (klijent.Id == prijava.KlijentId)
                        klijent.SignUpDate = prijava.Datum;
                }

                foreach (MPlan plan in mappedPlan)
                {
                    if (klijent.Id == plan.KlijentId)
                    {
                        if (plan.MentorstvoId != null)
                        {
                            if(klijent.MentorstvoId == null)
                                klijent.MentorstvoId = new List<int>();

                            klijent.MentorstvoId.Add(plan.MentorstvoId);
                        }

                        if (plan.Mentorstvo.UplataId != null)
                        {
                            if (klijent.UplataId == null)
                                klijent.UplataId = new List<int>();

                            klijent.UplataId.Add(plan.Mentorstvo.UplataId);
                        }
                    }
                }
            }

            return mappedList;
        }

        public Task<MKlijent> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<MKlijent> Update(int Id, KlijentUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
