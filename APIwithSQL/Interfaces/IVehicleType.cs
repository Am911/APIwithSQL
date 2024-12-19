using APIwithSQL.Models;

namespace APIwithSQL.Interfaces
{
    public interface IVehicleType
    {
        Task<int> Save(VehicleType vehicleType);
    }
}
