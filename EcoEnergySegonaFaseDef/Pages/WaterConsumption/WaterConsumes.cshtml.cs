using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Reflection.PortableExecutable;
using System.Xml;
using EcoEnergyTerceraFase.Models;
using EcoEnergyTerceraFase.Data;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class WaterConsumesModel : PageModel
    {
        
        public List<ConsumAigua> consums { get; set; } = new List<ConsumAigua>();
        public List<ConsumAigua> deuMunicipis = new List<ConsumAigua>();
        public Dictionary<string?, double> consumMitja { get; set; } = new Dictionary<string?, double>();
        public List<ConsumAigua> consumsSuspitosos { get; set; } = new List<ConsumAigua>();
        public List<string> consumsCreixents { get; set; } = new List<string>();
        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            consums = context.Consums.ToList();

            //Deu municipis amb mes consum
            List<ConsumAigua> ordenat = consums.OrderByDescending(n => n.Consumption).Take(10).ToList();
            ordenat.ForEach(deuMunicipis.Add);

            //Avg per municipis
            consumMitja = consums.
                 GroupBy(r => r.District)
                .ToDictionary(g => g.Key, g => g.Average(r => r.Total))
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //consusms sospitosos exessivament grans
            foreach (var i in consums)
            {
                if (i.Total.ToString().Length > 6)
                {
                    consumsSuspitosos.Add(i);
                }
            }

            //Consums creixents en el ultims 5 anys

            consumsCreixents = consums
            .GroupBy(r => r.District)
            .Where(g => g.Count() >= 5)
            .Select(g => new
            {
                District = g.Key,
                Trend = g.OrderBy(r => r.Year).Select(r => r.Total).ToList()
            })
            .Where(g => g.Trend.Zip(g.Trend.Skip(1), (a, b) => b > a).All(x => x))
            .Select(g => g.District)
            .ToList();
        }
    }
}
