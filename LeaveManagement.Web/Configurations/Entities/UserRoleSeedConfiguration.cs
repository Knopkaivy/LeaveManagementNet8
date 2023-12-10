using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "41c3d13b-aa32-4cea-add9-166ab4875243",
                    UserId = "0d3e459d-d328-4c1b-bf08-e039f322e9ee"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3d3e495d-d388-4c1b-bf88-e039f322e9ae",
                    UserId = "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f"
                }
                );
        }
    }
}