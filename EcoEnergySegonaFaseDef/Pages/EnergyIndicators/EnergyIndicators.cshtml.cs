using CsvHelper;
using EcoEnergyTerceraFase.Data;
using EcoEnergyTerceraFase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace EcoEnergySegonaFaseDef.Pages.EnergyIndicators
{
    public class EnergyIndicatorsModel : PageModel
    {
        public List<IndicadorsEnergetics> indicators { get; set; } = new List<IndicadorsEnergetics>();
        public List<IndicadorsEnergetics> produccioNetaSupTres = new List<IndicadorsEnergetics>();
        public List<IndicadorsEnergetics> consumGasolinaSupCen = new List<IndicadorsEnergetics>();
        public Dictionary<int, double> mitjanaProduccNeta = new Dictionary<int, double>();
        public List<IndicadorsEnergetics> demandaEleSupCuatr = new List<IndicadorsEnergetics>();
        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            indicators = context.Indicadors.ToList();

            //produccio neta major a 3000
            produccioNetaSupTres = indicators.Where(n => n.CDEEBC_ProdNeta > 3000).OrderBy(o => o.CDEEBC_ProdNeta).ToList();

            //consum gasolina major a 100
            consumGasolinaSupCen = indicators.Where(n => n.CCAC_GasolinaAuto > 100).OrderByDescending(o => o.CCAC_GasolinaAuto).ToList();

            //mitjana de produccio neta per any
            mitjanaProduccNeta = indicators
                .GroupBy(r => r.Data.Year)
                .ToDictionary(g => g.Key, g => g.Average(r => r.CDEEBC_ProdNeta))
                .OrderBy(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //demanda electrica major a 4000 i produccio disponible menor a 300
            demandaEleSupCuatr = indicators.Where(n => n.CDEEBC_DemandaElectr > 4000 && n.CDEEBC_ProdDisp < 300).ToList();
        }
    }
    
        
}
