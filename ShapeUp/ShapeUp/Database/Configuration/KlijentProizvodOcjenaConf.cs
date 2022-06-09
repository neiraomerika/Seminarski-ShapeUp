using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class KlijentProizvodOcjenaConf : IEntityTypeConfiguration<KlijentProizvodOcjena>
    {
        public void Configure(EntityTypeBuilder<KlijentProizvodOcjena> builder)
        {
            builder.HasData(
            new KlijentProizvodOcjena
            {
                Id = 1,
                Ocjena = 4,
                KlijentId = "korisnik",
                ProizvodId = 1,
            },
            new KlijentProizvodOcjena
            {
                Id = 2,
                Ocjena = 3,
                KlijentId = "korisnik",
                ProizvodId = 2,
            },
            new KlijentProizvodOcjena
            {
                Id = 3,
                Ocjena = 5,
                KlijentId = "korisnik",
                ProizvodId = 3,
            });


        }
    }
}
