using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShapeUp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Database.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Klijent>
    {
        public void Configure(EntityTypeBuilder<Klijent> builder)
        {
            builder.HasData(
            new Klijent
            {
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@admin.com",
                PhoneNumber = "123-123-123",
                UserName = "admin@admin.com",
                PasswordHash = "AQAAAAEAACcQAAAAEDN+cf7SfbN5luvDHi3DZKeie49/i/5EeXxD2tQauLllyyTrceb6qNjwb3aKXLfmxQ==",
            },
            new Klijent
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "test@test.com",
                PhoneNumber = "123-123-123",
                UserName = "test@test.com",
                PasswordHash = "AQAAAAEAACcQAAAAEDvqm0caG71RYK7u2oJYw+h6UQoXa9VqarhIW9mEZd+J1hffFcOuiGRAZaf7rpxvrA==",
                Active = true,
            });
        }
    }
}
