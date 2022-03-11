using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class MentorstvoConfiguration : IEntityTypeConfiguration<Mentorstvo>
    {
        public void Configure(EntityTypeBuilder<Mentorstvo> builder)
        {
            builder.HasData(
            new Mentorstvo
            {
               Id = 1,
               DatumPocetka = new DateTime(2022, 02, 01),
               DatumZavrsetka = new DateTime(2022, 02, 28),
               UplataId = 1,
               NazivKlijenta = "Test Test"
            },
            new Mentorstvo
            {
                Id = 2,
                DatumPocetka = new DateTime(2022, 03, 01),
                DatumZavrsetka = new DateTime(2022, 03, 31),
                UplataId = 2,
                NazivKlijenta = "Test Test"
            });
        }
    }
}
