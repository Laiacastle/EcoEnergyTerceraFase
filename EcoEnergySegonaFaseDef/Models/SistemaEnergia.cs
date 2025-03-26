using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcoEnergyTerceraFase.Models
{
    

    public class SistemaEnergia
    {
        
        public int Id { get; set; }
        public string? Tipus { get; set; }
        public double Rati { get; set; }
        public double EnergiaGenerada { get; set; }
        public double CostKWh { get; set; }
        public double PreuKWh { get; set; }
        public DateTime DataHora { get; set; }

        public virtual bool ConfParametre() { return true; }
        public virtual double CalcEnergia() { return 0.0; }
        public virtual void MostraInforme() { }

        

    }
}