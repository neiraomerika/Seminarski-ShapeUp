using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShapeUp.Database;
using ShapeUp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp
{
    public class SetupService
    {

        public void Init(ShapeUpDBContext context, UserManager<Klijent> userManager)
        {
            context.Database.Migrate();

            var korisnici = context.Set<Klijent>().AsQueryable();

            PasswordHasher<Klijent> hasher = new PasswordHasher<Klijent>();

            Klijent admin = korisnici.Where(x => x.FirstName == "Admin").First() as Klijent;
            Klijent klijent = korisnici.Where(x => x.FirstName == "Test").First() as Klijent;

            admin.PasswordHash = hasher.HashPassword(admin, "Lozinka123!");
            klijent.PasswordHash = hasher.HashPassword(klijent, "Lozinka123!");

            context.Update<Klijent>(admin);
            context.SaveChanges();

            context.Update<Klijent>(klijent);
            context.SaveChanges();
        }
    }
}
