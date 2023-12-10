using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                    Email = "test2@test.com",
                    NormalizedEmail = "TEST2@TEST.COM",
                    UserName = "test2@test.com",
                    NormalizedUserName = "TEST2@TEST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Test@Test1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                    Email = "tata@tata.com",
                    NormalizedEmail = "TATA@TATA.COM",
                    UserName = "tata@tata.com",
                    NormalizedUserName = "TATA@TATA.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Test@Test1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}