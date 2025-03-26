using EcoEnergyTerceraFase.Models;

namespace EcoEnergyTerceraFase.Cruds
{
    public interface IEnergyIndicatorDAO
    {
        public List<IndicadorsEnergetics> GetAllIndicators();
        public IndicadorsEnergetics GetIndicatorById(int indicatorId);
        public void AddIndicator(IndicadorsEnergetics newIndicator);
        public void DeleteIndicator(IndicadorsEnergetics oldIndicator);
        public void UpdateIndicator(IndicadorsEnergetics newIndicator);
    }
}
