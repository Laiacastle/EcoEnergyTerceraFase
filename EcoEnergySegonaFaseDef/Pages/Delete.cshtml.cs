using EcoEnergyTerceraFase.Data;
using EcoEnergyTerceraFase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergyTerceraFase.Pages
{
    public class DeleteModel : PageModel
    {
        public IActionResult OnGet(int? simulation, int? consume, int? indicator)
        {
            using var context = new ApplicationDbContext();
            if (simulation != null)
            {
                if (context.Simulacions.Find(simulation) != null)
                {
                    Simulacions sim = context.Simulacions.Find(simulation);
                    context.Simulacions.Remove(sim);
                    context.SaveChanges();
                }
                return RedirectToPage("./Simulations/Simulations");
            }
            else if (consume != null)
            {
                if(context.Consums.Find(consume) != null)
                {
                    ConsumAigua cons = context.Consums.Find(consume);
                    context.Consums.Remove(cons);
                    context.SaveChanges();
                }
                return RedirectToPage("./WaterConsumption/WaterConsumes");
            }
            else if(indicator != null)
            {
                if(context.Indicadors.Find(indicator) != null)
                {
                    IndicadorsEnergetics indi = context.Indicadors.Find(indicator);
                    context.Indicadors.Remove(indi);
                    context.SaveChanges();
                }
                return RedirectToPage("./EnergyIndicators/EnergyIndicators");
            }
            return RedirectToPage("Index");
        }
    }
}
