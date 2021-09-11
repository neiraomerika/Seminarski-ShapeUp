using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class CiljConfiguration : IEntityTypeConfiguration<Cilj>
    {
        public void Configure (EntityTypeBuilder<Cilj> builder)
        {
            builder.HasData(
            new Cilj
            {
                Naziv = "Mršavljenje",
                Id=1,

            },
            new Cilj
            {
                Naziv = "Dobivanje mišične mase",
                Id=2,
            });
           

        }
    }
}
