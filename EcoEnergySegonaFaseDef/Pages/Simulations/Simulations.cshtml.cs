using EcoEnergySegonaFaseDef.Pages.Simulations;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CsvHelper;
using EcoEnergyTerceraFase.Models;
using EcoEnergyTerceraFase.Data;

namespace EcoEnergySegonaFaseDef.Pages.Simulations
{
    public class SimulationsModel : PageModel
    {
        public List<Simulacions> sistems { get; set; } = new List<Simulacions>();

        public void OnGet()
        {
            using var context = new ApplicationDbContext();
            sistems = context.Simulacions.ToList();

        }
    }
}
