
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Gym_Membership_Managment_System.Context
{
    public class GymManagementDbContextFactory : IDesignTimeDbContextFactory<GymManagementDbContext>
    {
        public GymManagementDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                                .SetBasePath(AppContext.BaseDirectory)
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();


            string connectionString = configuration.GetConnectionString("constr")
                ?? throw new InvalidOperationException("Connection string 'constr' not found.");

            var options = new DbContextOptionsBuilder<GymManagementDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new GymManagementDbContext(options);
        }
    }
}
