using EcoEnergyTerceraFase.Data;
using EcoEnergyTerceraFase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergyTerceraFase.Pages
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Simulacions? simulation { get; set; } = null;
        [BindProperty]
        public ConsumAigua? consume { get; set; } = null;
        [BindProperty]
        public IndicadorsEnergetics? indicator { get; set; } = null;
        
        public void OnGet(int? simulationId, int? consumeId, int? indicatorId)
        {
            using var context = new ApplicationDbContext();
            
            if(simulationId != null)
            {
                if(context.Simulacions.Find(simulationId) != null)
                {
                    simulation = context.Simulacions.Find(simulationId);
                    
                }
            }else if(consumeId != null)
            {
                if (context.Consums.Find(consumeId) != null)
                {
                    consume = context.Consums.Find(consumeId);
                    
                }
            }else if(indicatorId != null)
            {
                if(context.Indicadors.Find(indicatorId) != null)
                {
                    indicator = context.Indicadors.Find(indicatorId);
                    
                }
            }
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            if (simulation.Value != 0)
            {
                context.Attach(simulation).State = EntityState.Modified;
                context.SaveChanges();
                simulation = null;
                return RedirectToPage("./Simulations/Simulations");
                
            }else if(consume.Consumption != 0)
            {
                
                context.Attach(consume).State = EntityState.Modified;
                context.SaveChanges();
                consume = null;
                return RedirectToPage("./WaterConsumption/WaterConsumes");
            }else if (indicator.CDEEBC_DemandaElectr != 0)
            {
                
                context.Attach(indicator).State = EntityState.Modified;
                context.SaveChanges();
                indicator = null;
                return RedirectToPage("./EnergyIndicators/EnergyIndicators");
            }
            return RedirectToPage("Index");
        }
    }
}
