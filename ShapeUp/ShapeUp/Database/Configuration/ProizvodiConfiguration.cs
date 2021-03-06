using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class ProizvodiConfiguration : IEntityTypeConfiguration<Proizvod>
    {
        public void Configure(EntityTypeBuilder<Proizvod> builder)
        {
            builder.HasData(
            new Proizvod
            {
                Id = 1,
                Naziv = "Gold Whey",
                Opis = "25g proteina u jednoj mjerici ovog nevjerovatnog proteina",
                ProsjecnaOcjena = 4,
                Cijena = 98,
                KategorijaProizvodaId = 2,
                Slika = null
            },
            new Proizvod
            {
                Id = 2,
                Naziv = "Vitamin C",
                Opis = "1000mg vitamina c",
                ProsjecnaOcjena = 3,
                Cijena = 20,
                KategorijaProizvodaId = 9,
                Slika = null
            },
            new Proizvod
            {
                Id = 3,
                Naziv = "Creatine Monohydrate",
                Opis = "4g kreatina po mjerici. Brza apsorpcija.",
                ProsjecnaOcjena = 5,
                Cijena = 35,
                KategorijaProizvodaId = 6,
                Slika = null
            });
        }
    }
}
