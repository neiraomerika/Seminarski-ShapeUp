using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class PlanPrehraneConfiguration : IEntityTypeConfiguration<PlanPrehrane>
    {
        public void Configure (EntityTypeBuilder<PlanPrehrane> builder)
        {
            builder.HasData(
            new PlanPrehrane
            {
                Id=1,
                Opis = "1. Obrok: 5 jaja\n" +
                "2. Obrok: Leso meso i kuhani krompir\n" +
                "3. Corn Flakes se whey proteinom",
                Slika = null,
                NutritivneVrijednosti = "1. Obrok: 30g prot, \n" +
                "2. Obrok: 40g prot\n" +
                "3. Obrok: 25g prot\n",
                CiljId=2,

            },
            new PlanPrehrane
            {
                Id=2,
                Opis = "1. Obrok: 2 jaja\n" +
                "2. Obrok: Pileca salata\n" +
                "3. Casa vode",
                Slika = null,
                NutritivneVrijednosti = "1. Obrok: 12g prot, \n" +
                "2. Obrok: 25g prot\n" +
                "3. Obrok: 0g prot\n",
                CiljId=1,

            });
           

        }
    }
}
