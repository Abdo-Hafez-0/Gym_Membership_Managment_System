using Gym_Membership_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Membership_Managment_System.Configuration
{
    public class MembershipPlanConfiguration : IEntityTypeConfiguration<MembershipPlan>
    {
        public void Configure(EntityTypeBuilder<MembershipPlan> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(p => p.DurationInMonths)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(500);
        }
    }
}
