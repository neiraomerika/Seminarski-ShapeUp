using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class KategProizvodaConfiguration : IEntityTypeConfiguration<KategorijaProizvodum>
    {
        public void Configure (EntityTypeBuilder<KategorijaProizvodum> builder)
        {
            builder.HasData(
            new KategorijaProizvodum
            {
                Naziv = "amino kiseline",
                Id=1

            },
            new KategorijaProizvodum
            {
                Naziv = "protein",
                Id=2
            },
            new KategorijaProizvodum
            {
                Naziv = "energetska pica",
                Id=3
                
            },
            new KategorijaProizvodum
            {
                Naziv = "gejneri",
                Id=4
            },
            new KategorijaProizvodum
            {
                Naziv = "gubljenje kilograma",
                Id=5
            },
            new KategorijaProizvodum
            {
                Naziv = "kreatin",
                Id = 6
            },
            new KategorijaProizvodum
            {
                Naziv = "pre-workout",
                Id = 7
            },
            new KategorijaProizvodum
            {
                Naziv = "hormonski pojacivaci",
                Id = 8
            },
            new KategorijaProizvodum
            {
                Naziv = "vitamini & minerali",
                Id = 9
            });

        }
    }
}
