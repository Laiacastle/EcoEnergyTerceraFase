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
        [Required]
        public string? Tipus { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        [Range(0.1, 0.3)]
        public double Rati { get; set; }
        [Required]
        public double EnergiaGenerada { get; set; }
        public double CostKWh { get; set; }
        public double PreuKWh { get; set; }
        [Required]
        public DateTime DataHora { get; set; }
        
    }
}
