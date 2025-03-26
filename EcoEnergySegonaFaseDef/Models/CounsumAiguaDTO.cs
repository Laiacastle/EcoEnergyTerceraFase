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
        public int Year { get; set; }
        public int CodeDistrict { get; set; }
        public string? District { get; set; }
        public int Poblation { get; set; }
        public int Network { get; set; }
        public int FontsAndEcoActivities { get; set; }
        public int Total { get; set; }
        public double Consumption { get; set; }

    }
}
