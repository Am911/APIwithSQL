using APIwithSQL.Models;

namespace APIwithSQL.Interfaces
{
    public interface IVehicleType
    {
        Task<int> Save(VehicleType vehicleType);
        List<VehicleType> GetAll();

        bool updateRecord(dynamic id, VehicleType VT);
        bool removeById(dynamic id);
    }
}
