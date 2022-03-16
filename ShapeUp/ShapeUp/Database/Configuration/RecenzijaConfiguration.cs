using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class RecenzijaConfiguration : IEntityTypeConfiguration<Recenzija>
    {
        public void Configure(EntityTypeBuilder<Recenzija> builder)
        {
            builder.HasData(
            new Recenzija
            {
                Id = 1,
                Opis = "Vrlo dobro odradjen mjesec, u slijedecem idemo jos jace.",
                Ocjena = 4,
                Datum = DateTime.Now,
                MentorstvoId = 1,
            });
        }
    }
}
