using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergyTerceraFase.Models
{
    [Table("IndicadorsEnergetics")]
    public class IndicadorsEnergetics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Name("Data")]
        [Required]
        public DateTime Data { get; set; }
        [Name("CDEEBC_ProdNeta")]
        [Required]
        public double CDEEBC_ProdNeta { get; set; }
        [Name("CDEEBC_ProdDisp")]
        [Required]
        public double CDEEBC_ProdDisp { get; set; }
        [Name("CDEEBC_DemandaElectr")]
        [Required]
        public double CDEEBC_DemandaElectr { get; set; }
        [Name("CCAC_GasolinaAuto")]
        [Required]
        public double CCAC_GasolinaAuto { get; set; }
        

    }
}
