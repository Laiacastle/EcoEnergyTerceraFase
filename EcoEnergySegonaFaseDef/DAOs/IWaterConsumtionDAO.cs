using EcoEnergySegonaFaseDef.Pages.WaterConsumption;
using EcoEnergyTerceraFase.Models;

namespace EcoEnergyTerceraFase.Cruds
{
    public interface IWaterConsumtionDAO
    {
        public List<ConsumAigua> GetAllConsumes();
        public ConsumAigua GetConsumeById(int consumeId);
        public void AddConsume(ConsumAigua newConsume);
        public void DeleteConsume(ConsumAigua oldConsume);
        public void UpdateConsume(ConsumAigua newConsume);
    }
}
