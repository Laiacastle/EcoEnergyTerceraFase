using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyTerceraFase.Mapping;
using EcoEnergyTerceraFase.Models;
using System.Globalization;

namespace EcoEnergyTerceraFase.Data
{
    public class ApplicationDbIniatilazer
    {
        private readonly ApplicationDbContext _context;
        public ApplicationDbIniatilazer(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (!_context.Consums.Any()) 
            {
                var consumes = ReadConsumes("../../wwwroot/BaseFiles/consum_aigua_cat_per_comarques.csv");
                _context.Consums.AddRange(consumes);
                _context.SaveChanges();
            }
            if(!_context.Indicadors.Any())
            {
                var indicators = ReadIndicators("../../wwwroot/BaseFiles/indicadors_energetics_cat.csv");
                _context.Indicadors.AddRange(indicators);
                _context.SaveChanges();
            }
        }

        public static IEnumerable<ConsumAigua> ReadConsumes(string filepath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null,
                HeaderValidated = null
            };
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ConsumAiguaMAP>();
                return csv.GetRecords<ConsumAigua>().ToList();
            }
        }
        
        public static IEnumerable<IndicadorsEnergetics> ReadIndicators(string filepath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null,
                HeaderValidated = null
            };
            using (var reader = new StreamReader(filepath))
                using (var csv = new CsvReader (reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<IndicadorsEnergeticsMAP>();
                return csv.GetRecords<IndicadorsEnergetics>().ToList();
            }
        }
    }
}
