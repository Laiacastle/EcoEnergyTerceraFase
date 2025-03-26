using Microsoft.AspNetCore.Mvc;
using CsvHelper;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Reflection.PortableExecutable;
using System.Xml;
using EcoEnergyTerceraFase.Models;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class WaterConsumesModel : PageModel
    {
        [XmlRoot("Consums")]
        public class Consums
        {
            [XmlElement("consum")]
            public List<ConsumAigua> ConsumList { get; set; } = new List<ConsumAigua>();
        }
        public List<ConsumAigua> consums { get; set; } = new List<ConsumAigua>();
        public List<ConsumAigua> deuMunicipis = new List<ConsumAigua>();
        public Dictionary<string?, double> consumMitja { get; set; } = new Dictionary<string?, double>();
        public List<ConsumAigua> consumsSuspitosos { get; set; } = new List<ConsumAigua>();
        public List<string> consumsCreixents { get; set; } = new List<string>();
        public void OnGet()
        {
            throw new NotImplementedException();
        }
    }
}
