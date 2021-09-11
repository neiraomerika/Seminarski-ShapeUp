using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class KategTreningConfiguration : IEntityTypeConfiguration<KategorijaTreninga>
    {
        public void Configure (EntityTypeBuilder<KategorijaTreninga> builder)
        {
            builder.HasData(
            new KategorijaTreninga
            {
                Naziv = "Noge",
                Id=1

            },
            new KategorijaTreninga
            {
                Naziv = "Gluteus",
                Id=2
            },
            new KategorijaTreninga
            {
                Naziv = "Stomak",
                Id=3
                
            },
            new KategorijaTreninga
            {
                Naziv = "Ruke",
                Id=4
            });

        }
    }
}
