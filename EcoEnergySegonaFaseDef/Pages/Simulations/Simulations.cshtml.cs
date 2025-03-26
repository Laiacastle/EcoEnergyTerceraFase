using EcoEnergySegonaFaseDef.Pages.Simulations;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CsvHelper;
using EcoEnergyTerceraFase.Models;

namespace EcoEnergySegonaFaseDef.Pages.Simulations
{
    public class SimulationsModel : PageModel
    {
        public List<Simulacions> sistems { get; set; } = new List<Simulacions>();

        public void OnGet()
        {
            string filePath = "./Pages/Files/simulations.csv";
            if (System.IO.File.Exists(filePath))
            {/*
                var lines = System.IO.File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            sistems = csv.GetRecords<Simulacions>().ToList();
                        }
                    }
                */
                }
            }
        }
    }
