using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class TreningConfiguration : IEntityTypeConfiguration<Trening>
    {
        public void Configure (EntityTypeBuilder<Trening> builder)
        {
            builder.HasData(
            new Trening
            {
                Id=1,
                Opis = "1. Pull-Ups: 4x10\n" +
                "2. Bent-Over Row: 4x10\n" +
                "3. Lat Pull-Down: 5x8\n" +
                "4. Single-Arm Smith Machine Row: 3x12\n" +
                "5. Deadlift: 5x5\n",
                VideoUrl = "https://www.youtube.com/c/SmaykiFitness",
                CiljId=2,
                KategorijaTreningaId=5,

            },
            new Trening
            {
                Id=2,
                Opis = "1. Biceps Z-Curl: 4x10\n" +
                "   Triceps Cable Extension: 4x10\n" +
                "2. Biceps Curls: 3x12\n" +
                "   Single-Arm Cable Triceps Extension: 3x12\n" +
                "3. Biceps Hammer Curls: 4x10\n" +
                "   Dips 4x10",
                VideoUrl = "https://www.youtube.com/c/SmaykiFitness",
                CiljId=2,
                KategorijaTreningaId=4,

            });
           

        }
    }
}
