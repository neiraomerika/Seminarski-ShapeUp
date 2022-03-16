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
        }
    }
}
