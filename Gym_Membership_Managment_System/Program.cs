using Gym_Membership_Managment_System.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gym_Membership_Managment_System
{
    internal class Program
    {

        static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
        
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
        

                string connectionString = configuration.GetConnectionString("constr")
                    ?? throw new InvalidOperationException("Connection string 'constr' not found.");
        
                var service = new ServiceCollection();
        
                service.AddDbContext<GymManagementDbContext>(options =>
                    options.UseSqlServer(connectionString));
        
                
        }
        
    }
}
