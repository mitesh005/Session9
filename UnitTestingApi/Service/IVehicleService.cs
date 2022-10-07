using UnitTestingApi.Model;

namespace UnitTestingApi.Service
{
    public interface IVehicleService
    {
        public List<VehicleInfo> GetAllVehicles();
    }
}
