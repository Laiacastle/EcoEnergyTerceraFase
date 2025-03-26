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
        public DateTime Data { get; set; }
        public double CDEEBC_ProdNeta { get; set; }
        public double CDEEBC_ProdDisp { get; set; }
        public double CDEEBC_DemandaElectr { get; set; }
        public double CCAC_GasolinaAuto { get; set; }
        

    }
}
