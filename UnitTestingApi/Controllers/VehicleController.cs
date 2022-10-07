using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestingApi.Model;
using UnitTestingApi.Service;

namespace UnitTestingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;
        public VehicleController(IVehicleService _vehicleService)
        {
            this.vehicleService = _vehicleService;

        }
        [HttpGet]
        public IActionResult GetAllVehicles()
        {
           List<VehicleInfo> vehicleInfos= vehicleService.GetAllVehicles();
            return Ok(vehicleInfos);
        }


    }
}
