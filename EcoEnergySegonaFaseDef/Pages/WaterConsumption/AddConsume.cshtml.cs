using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.Drawing;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Xml.Serialization;
using System.Xml;
using EcoEnergyTerceraFase.Models;
using EcoEnergyTerceraFase.Data;

namespace EcoEnergySegonaFaseDef.Pages.WaterConsumption
{
    public class AddConsumeModel : PageModel
    {
        [BindProperty]
        public ConsumAigua consum { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            context.Consums.Add(consum);
            context.SaveChanges();
            return RedirectToPage("WaterConsumes");
        }
    }
}
