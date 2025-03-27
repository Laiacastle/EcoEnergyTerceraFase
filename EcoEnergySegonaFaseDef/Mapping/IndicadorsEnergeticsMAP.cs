using CsvHelper.Configuration;
using EcoEnergyTerceraFase.Models;

namespace EcoEnergyTerceraFase.Mapping
{
    public class IndicadorsEnergeticsMAP: ClassMap<IndicadorsEnergetics>
    {
        public IndicadorsEnergeticsMAP()
        {
            Map(n => n.Data).Name("Data");
            Map(n => n.CDEEBC_ProdNeta).Name("CDEEBC_ProdNeta");
            Map(n => n.CDEEBC_ProdDisp).Name("CDEEBC_ProdDisp");
            Map(n => n.CDEEBC_DemandaElectr).Name("CDEEBC_DemandaElectr");
            Map(n => n.CCAC_GasolinaAuto).Name("CCAC_GasolinaAuto");
            
        }
    }
}
