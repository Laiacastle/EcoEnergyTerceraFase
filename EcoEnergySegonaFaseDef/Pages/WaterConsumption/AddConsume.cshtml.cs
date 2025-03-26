using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.Drawing;
using static EcoEnergySegonaFaseDef.Pages.WaterConsumption.WaterConsumesModel;
using System.Xml.Serialization;
using System.Xml;
using EcoEnergyTerceraFase.Models;

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
            throw new NotImplementedException();
        }
    }
}
