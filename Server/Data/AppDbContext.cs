using Microsoft.EntityFrameworkCore;
using IPOPHLTrademark.Client.Models;

namespace IPOPHLTrademark.Client.Data
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"));
        }

        
    }
}