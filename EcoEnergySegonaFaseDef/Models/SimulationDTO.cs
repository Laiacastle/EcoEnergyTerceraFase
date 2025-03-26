using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoEnergyTerceraFase.Models
{
    [Table("Simulacions")]

    public class Simulacions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Tipus { get; set; }
        public double Value { get; set; }
        public double Rati { get; set; }
        public double EnergiaGenerada { get; set; }
        public double CostKWh { get; set; }
        public double PreuKWh { get; set; }
        public DateTime DataHora { get; set; }
        
    }
}
