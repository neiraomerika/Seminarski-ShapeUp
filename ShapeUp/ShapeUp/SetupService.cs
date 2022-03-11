using Microsoft.EntityFrameworkCore;
using ShapeUp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp
{
    public class SetupService
    {
        public void Init(ShapeUpDBContext context)
        {
            context.Database.Migrate();
        }
    }
}
