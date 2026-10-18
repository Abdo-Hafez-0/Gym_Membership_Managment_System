using Gym_Membership_Managment_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym_Membership_Managment_System.Context
{
    public class GymManagementDbContext : DbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> contextOptions)
            :base(contextOptions)
        {
            
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<MembershipPlan> MembershipPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymManagementDbContext).Assembly);
        }

    }
}
