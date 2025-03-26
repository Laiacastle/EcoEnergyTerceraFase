using EcoEnergyTerceraFase.Models;
namespace EcoEnergyTerceraFase.Cruds
{
    public interface ISimulationDAO
    {
        public List<Simulacions> GetAllSimulations();
        public Simulacions GetSimulationById(int simulationId);
        public void AddSimulation(Simulacions newSimulation);
        public void DeleteSimulation(Simulacions oldSimulation);
        public void UpdateSimulation(Simulacions newSimulation);
    }
}
