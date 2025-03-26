using EcoEnergyTerceraFase.Data;
using EcoEnergyTerceraFase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySegonaFaseDef.Pages.Simulations
{
    public class AddSimulationModel : PageModel
    {

        [BindProperty]
        public SistemaEnergia sistema { get; set; }
        [BindProperty]
        public SistemaSolar solar { get; set; }
        [BindProperty]
        public SistemaEolica eolica { get; set; }
        [BindProperty]
        public SistemaHidroelectrica hidro { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();
            Simulacions simulacio;
            string filePath = "./Pages/Files/simulations.csv";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (!hidro.ConfParametre())
            {
                ModelState.AddModelError("SistemaHidroelectrica.CabalAigua", "El cabal d'aigua ha de ser major a 19");
                return Page();
            }
            if (!eolica.ConfParametre())
            {
                ModelState.AddModelError("SistemaEolica.VelocitatVent", "La velocitat del vent ha de ser major a 5");
                return Page();
            }
            if (!solar.ConfParametre())
            {
                ModelState.AddModelError("SistemaSolar.HoresSol", "Les hodes de sal han de ser major a 0");
                return Page();
            }
            switch (sistema.Tipus)
            {
                case "Solar": 
                    simulacio = new Simulacions { Tipus = sistema.Tipus, Rati = sistema.Rati, EnergiaGenerada = sistema.EnergiaGenerada, CostKWh = sistema.CostKWh, PreuKWh = sistema.PreuKWh, DataHora = sistema.DataHora, Value = solar.HoresSol }
                    ;break;
                case "Eolica": simulacio = new Simulacions { Tipus = sistema.Tipus, Rati = sistema.Rati, EnergiaGenerada = sistema.EnergiaGenerada, CostKWh = sistema.CostKWh, PreuKWh = sistema.PreuKWh, DataHora = sistema.DataHora, Value = eolica.VelocitatVent }; break;
                case "Hidroelectrica": simulacio = new Simulacions { Tipus = sistema.Tipus, Rati = sistema.Rati, EnergiaGenerada = sistema.EnergiaGenerada, CostKWh = sistema.CostKWh, PreuKWh = sistema.PreuKWh, DataHora = sistema.DataHora, Value = solar.HoresSol }; break;
                default: simulacio = new Simulacions { Tipus = sistema.Tipus, Rati = sistema.Rati, EnergiaGenerada = sistema.EnergiaGenerada, CostKWh = sistema.CostKWh, PreuKWh = sistema.PreuKWh, DataHora = sistema.DataHora, Value = solar.HoresSol }; break;
            }
            context.Simulacions.Add(simulacio);
            context.SaveChanges();
            return RedirectToPage("Simulations");
        }
    }
}

