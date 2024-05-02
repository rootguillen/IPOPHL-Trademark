using IPOPHLTrademark.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace IPOPHLTrademark.Client.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for each entity model
        public DbSet<TrademarkInformationModel> TrademarkInformations { get; set; }
        public DbSet<ApplicantInformationModel> ApplicantInformations { get; set; }
        //public DbSet<ApplicantTypeModel> ApplicantTypes { get; set; }
        public DbSet<ResidentAgentInformationModel> ResidentAgentInformations { get; set; }
        public DbSet<GoodsServicesInformationModel> GoodsServicesInformations { get; set; }
        public DbSet<ClaimConventionPriorityModel> ClaimConventionPriorities { get; set; }

        // Other configuration or customization as needed
    }
}
