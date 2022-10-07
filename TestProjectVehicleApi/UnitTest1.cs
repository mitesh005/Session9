using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using UnitTestingApi.Controllers;
using UnitTestingApi.Model;
using UnitTestingApi.Service;

namespace TestProjectVehicleApi
{
    public class UnitTest1
    {
        private readonly VehicleController _controller;
        private readonly IVehicleService _service;
        public UnitTest1()
        {
            _service= new VehicleService();
            _controller=new VehicleController(_service);
        }
        [Fact]
        public void Test1()
        {
            var okResult = _controller.GetAllVehicles() as OkObjectResult;
            var items = Assert.IsType<List<VehicleInfo>>(okResult.Value);
            Assert.Equal(2, items.Count);
           



        }
    }
}