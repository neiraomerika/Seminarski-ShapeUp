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
                ProsjecnaOcjena = 5,
                Cijena = 98,
                KategorijaProizvodaId = 2,
                Slika = null
            },
            new Proizvod
            {
                Id = 2,
                Naziv = "Vitamin C",
                Opis = "1000mg vitamina c",
                ProsjecnaOcjena = 5,
                Cijena = 20,
                KategorijaProizvodaId = 9,
                Slika = null
            });
        }
    }
}
