using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
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
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class KlijentService : IKlijentService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<Klijent> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;

        public KlijentService(ShapeUpDBContext context,
                              IMapper mapper,
                              UserManager<Klijent> userManager,
                              RoleManager<IdentityRole> roleManager,
                              IEmailSender emailSender)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
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
            if(search.Active != null)
            {
                klijenti = klijenti.Where(x => x.Active == search.Active);
            }

            var list = await klijenti.ToListAsync();
            var mappedClients = _mapper.Map<List<MKlijent>>(list);
            var mappedPlan = _mapper.Map<List<MPlan>>(mentorshipPlans).AsQueryable();

            foreach (MKlijent klijent in mappedClients)
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
                        if (klijent.Plans == null)
                            klijent.Plans = new List<MPlan>();

                        klijent.Plans.Add(plan);
                    }
                }
            }

            return mappedClients;
        }

        public async Task<MKlijent> GetById(string Id)
        {
            try
            {
                var klijent = _context.Set<Klijent>().AsQueryable();

                if (!string.IsNullOrEmpty(Id))
                    klijent = klijent.Where(x => x.Id == Id);

                var lista = await klijent.FirstAsync();

                return _mapper.Map<MKlijent>(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<MKlijent> Update(string Id, KlijentUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string Id)
        {
            var klijent = _context.Set<Klijent>().Find(Id);
            try
            {
                _context.Set<Klijent>().Remove(klijent);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<MKlijent> Insert(KlijentInsertRequest request)
        {
            var entity = new Klijent() 
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                UserName = request.Email
            };

            var result = await _userManager.CreateAsync(entity, request.Password);
            var role = _roleManager.FindByNameAsync(request.Role).Result;

            if (!result.Succeeded)
            {
                var err = result.Errors.Select(e => e.Description);

                throw new Exception();
            }

            if (result.Succeeded)
            {
                var roleAdd = await _userManager.AddToRoleAsync(entity, request.Role);

                if (!roleAdd.Succeeded)
                    throw new Exception();

                string subject = "Shape Up - Lozinka korisničkog računa";
                string htmlMessage = @"Poštovani,<br/><br/>" + "Lozinka za vas korisnički račun je: <b>{0}</b><br/>" + "Molimo Vas da nakon prijave promijenite svoju lozinku." + "<br/><br/>" + "Lijep pozdrav!" + "<br/>" + "Shape Up admin tim";
                htmlMessage = string.Format(htmlMessage, request.Password);
                await _emailSender.SendEmail(request.Email, subject, htmlMessage);

                return _mapper.Map<MKlijent>(entity);
            }
            return _mapper.Map<MKlijent>(null);
        }
    }
}
