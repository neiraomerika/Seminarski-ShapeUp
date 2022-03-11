using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        private ShapeUpDBContext context;
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasData(
            new Plan
            {
                Id = 1,
                Datum = new DateTime(2022, 03, 12),
                TreningId = 1,
                PlanPrehraneId = 1,
                MentorstvoId = 1,
                KlijentId = "korisnik",
            },
            new Plan
            {
                Id = 2,
                Datum = new DateTime(2022, 03, 13),
                TreningId = 1,
                PlanPrehraneId = 1,
                MentorstvoId = 1,
                KlijentId = "korisnik",
            });
        }
    }
}
