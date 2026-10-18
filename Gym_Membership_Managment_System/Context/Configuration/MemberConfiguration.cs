

using Gym_Membership_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Membership_Managment_System.Context.Configuration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(m => m.ID);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
