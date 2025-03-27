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
        public DateTime Data { get; set; }
        [Name("CDEEBC_ProdNeta")]
        public double CDEEBC_ProdNeta { get; set; }
        [Name("CDEEBC_ProdDisp")]
        public double CDEEBC_ProdDisp { get; set; }
        [Name("CDEEBC_DemandaElectr")]
        public double CDEEBC_DemandaElectr { get; set; }
        [Name("CCAC_GasolinaAuto")]
        public double CCAC_GasolinaAuto { get; set; }
        

    }
}
