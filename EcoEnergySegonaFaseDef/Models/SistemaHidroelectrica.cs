using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergyTerceraFase.Models
{
    public class SistemaHidroelectrica : SistemaEnergia
    {
        
        public double CabalAigua { get; set; }
        public override double CalcEnergia() => Math.Round(CabalAigua * 9.8 * Rati);
        
        
    }
}
