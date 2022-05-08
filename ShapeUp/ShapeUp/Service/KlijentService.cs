using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using ShapeUp.Database.Models;
using ShapeUp.Interface;
using ShapeUp.Model.Dto;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        private Klijent _klijent;

        public KlijentService(ShapeUpDBContext context,
                              IHttpContextAccessor httpContextAccessor,
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

            if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                _klijent = _context.Users.First(x => x.UserName == httpContextAccessor.HttpContext.User.Identity.Name);
        }

        public async Task<List<MKlijent>> Get(KlijentSearchObject search)
        {
            var klijenti = _context.Set<Klijent>().AsQueryable();

            var signUps = _context.Set<Prijava>().AsQueryable();

            var mentorshipPlans = _context.Set<Plan>().AsQueryable()
                .Include(x => x.Mentorstvo)
                .Include(x => x.Mentorstvo).ThenInclude(x => x.Uplata)
                .Include(x => x.PlanPrehrane)
                .Include(x => x.Trening);

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
                var signUp = _context.Set<Prijava>().AsQueryable();
                var mentorshipPlans = _context.Set<Plan>().AsQueryable()
                .Include(x => x.Mentorstvo)
                .Include(x => x.Mentorstvo).ThenInclude(x => x.Uplata)
                .Include(x => x.PlanPrehrane)
                .Include(x => x.Trening);

                if (!string.IsNullOrEmpty(Id))
                {
                    klijent = klijent.Where(x => x.Id == Id);
                    signUp = signUp.Where(x => x.KlijentId == Id);
                }

                var lista = await klijent.FirstAsync();
                var mappedClient = _mapper.Map<MKlijent>(lista);
                var mappedPlan = _mapper.Map<List<MPlan>>(mentorshipPlans).AsQueryable();

                foreach (Prijava item in signUp)
                {
                    mappedClient.SignUpDate = item.Datum;
                }

                foreach (MPlan plan in mappedPlan)
                {
                    if (mappedClient.Id == plan.KlijentId)
                    {
                        if (mappedClient.Plans == null)
                            mappedClient.Plans = new List<MPlan>();

                        mappedClient.Plans.Add(plan);
                    }
                }

                return mappedClient;
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

            string password = generatePassword();

            var result = await _userManager.CreateAsync(entity, password);
            var role = _roleManager.FindByNameAsync(request.Role).Result;

            if (!result.Succeeded)
            {
                return _mapper.Map<MKlijent>(null);
            }

            if (result.Succeeded)
            {
                var roleAdd = await _userManager.AddToRoleAsync(entity, request.Role);

                if (!roleAdd.Succeeded)
                    throw new Exception();

                var prijave = _context.Set<Prijava>().AsQueryable();
                if(prijave != null)
                {
                    var prijava = prijave.Where(x => x.KlijentId == entity.Id);
                    if(!prijava.Any())
                    {
                        Prijava nova = new Prijava()
                        {
                            Datum = DateTime.Now,
                            KlijentId = entity.Id
                        };
                    
                        _context.Add<Prijava>(nova);
                        _context.SaveChanges();
                    }

                }

                string subject = "Shape Up - Lozinka korisničkog računa";
                string htmlMessage = @"Poštovani,<br/><br/>" + "Lozinka za vas korisnički račun je: <b>{0}</b><br/>" + "<br/><br/>" + "Lijep pozdrav!" + "<br/>" + "Shape Up admin tim";
                htmlMessage = string.Format(htmlMessage, password);
                await _emailSender.SendEmail(request.Email, subject, htmlMessage);

                return _mapper.Map<MKlijent>(entity);
            }
            return _mapper.Map<MKlijent>(null);
        }

        string generatePassword ()
        {
            var chars = "1234567890zxcvbnmasdfghjklqwertyuiop";
            int length = 10;
            string password = null;
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                password += chars[random.Next(0, chars.Length)];
            }
            return password;
        }

        public async Task<MKlijent> GetProfileInfo()
        {
            var klijent = _context.Set<Klijent>().AsQueryable();
            var signUp = _context.Set<Prijava>().AsQueryable();

            if(_klijent != null)
            {
                klijent = klijent.Where(x => x.Id == _klijent.Id);
                signUp = signUp.Where(x => x.KlijentId == _klijent.Id);
            }

            var lista = await klijent.FirstAsync();
            var mappedClient = _mapper.Map<MKlijent>(lista);

            foreach (Prijava item in signUp)
            {
                mappedClient.SignUpDate = item.Datum;
            }

            return mappedClient;
        }

        public async Task<string> PostProfilePicture(UserImageUpload image)
        {
            if (_klijent != null)
            {
                var klijent = _context.Set<Klijent>().Find(_klijent.Id);
                klijent.Picture = Convert.FromBase64String(image.Image);
                _context.Update<Klijent>(klijent);
                await _context.SaveChangesAsync();
            
                return "Uspjesno dodana slika";
            }
            return null;
        }
    }
}
