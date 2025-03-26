using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergyTerceraFase.Models
{
    public class SistemaSolar : SistemaEnergia
    {
        
        public double HoresSol { get; set; }
        public override double CalcEnergia() => Math.Round(HoresSol * Rati);
        
        
    }
}
