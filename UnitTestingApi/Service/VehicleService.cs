using UnitTestingApi.Model;

namespace UnitTestingApi.Service
{
    public class VehicleService:IVehicleService
    {
        List<VehicleInfo> vehicleInfos = new List<VehicleInfo>()
       {
           new VehicleInfo(){RegNo="Ab200",VehicleName="BMW"},
           new VehicleInfo(){RegNo="MB300",VehicleName="CZ"}
       };

        public List<VehicleInfo> GetAllVehicles()
        {
            return vehicleInfos;
        }

    }
}
