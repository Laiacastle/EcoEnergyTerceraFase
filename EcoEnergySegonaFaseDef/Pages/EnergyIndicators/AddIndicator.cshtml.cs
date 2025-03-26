using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using EcoEnergyTerceraFase.Models;
using EcoEnergyTerceraFase.Data;
namespace EcoEnergySegonaFaseDef.Pages.EnergyIndicators
{
    public class AddIndicatorModel : PageModel
    {
        [BindProperty]
        public IndicadorsEnergetics indicator {get;set;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            using var context = new ApplicationDbContext();

            context.Indicadors.Add(indicator);
            context.SaveChanges();
            return RedirectToPage("EnergyIndicators");
        }
    }
}
