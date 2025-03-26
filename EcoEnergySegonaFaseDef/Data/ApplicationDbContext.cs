using EcoEnergyTerceraFase.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace EcoEnergyTerceraFase.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Simulacions> Simulacions { get; set; }
        public DbSet<ConsumAigua> Consums { get; set; }
        public DbSet<IndicadorsEnergetics> Indicadors {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
        }
    }
}
