using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class PrijavaConfiguration : IEntityTypeConfiguration<Prijava>
    {
        public void Configure(EntityTypeBuilder<Prijava> builder)
        {
            builder.HasData(
            new Prijava
            {
                Id = 1,
                Datum = DateTime.Now,
                KlijentId = "KLIJENT",
            });
        }
    }
}
