using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class UplataConfiguration : IEntityTypeConfiguration<Uplatum>
    {
        public void Configure(EntityTypeBuilder<Uplatum> builder)
        {
            builder.HasData(
            new Uplatum
            {
                Id = 1,
                Datum = DateTime.Now,
                Iznos = 200
            },
            new Uplatum
            {
                Id = 2,
                Datum = DateTime.Now,
                Iznos = 250
            });
        }
    }
}
