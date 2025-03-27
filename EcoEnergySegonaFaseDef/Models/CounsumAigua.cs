using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace EcoEnergyTerceraFase.Models
{
    [Table("ConsumAigua")]
    public class ConsumAigua
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Name("Year")]
        public int Year { get; set; }
        [Name("CodeDistrict")]
        [Required]
        public int CodeDistrict { get; set; }
        [Name("District")]
        public string? District { get; set; }
        [Name("Poblation")]
        public int Poblation { get; set; }
        [Name("Network")]
        public int Network { get; set; }
        [Name("FontsAndEcoActivities")]
        public int FontsAndEcoActivities { get; set; }
        [Name("Total")]
        [Required]
        public int Total { get; set; }
        [Name("Consumption")]
        [Required]
        public double Consumption { get; set; }

    }
}
