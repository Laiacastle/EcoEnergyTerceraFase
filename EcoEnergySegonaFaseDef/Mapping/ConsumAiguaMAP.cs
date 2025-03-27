using CsvHelper.Configuration;
using EcoEnergyTerceraFase.Models;

namespace EcoEnergyTerceraFase.Mapping
{
    public class ConsumAiguaMAP: ClassMap<ConsumAigua>
    {
        public ConsumAiguaMAP()
        {
            Map(n => n.Year).Name("Year");
            Map(n => n.CodeDistrict).Name("CodeDistrict");
            Map(n => n.District).Name("District");
            Map(n => n.Poblation).Name("Poblation");
            Map(n => n.Network).Name("Network");
            Map(n => n.FontsAndEcoActivities).Name("FontsAndEcoActivities");
            Map(n => n.Total).Name("Total");
            Map(n => n.Consumption).Name("Consumption");
        }
    }
}
