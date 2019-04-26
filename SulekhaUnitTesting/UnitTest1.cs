/*using System;
using Xunit;
using Sulekha.Controllers;
using Sulekha.Models;
using Sulekha.Models.DataManager;

namespace SulekhaUnitTesting
{
    public class BusinessTest
    {
        BusinessController _businessController;
        BusinessManager _manager;

        public BusinessTest()
        {
            _manager = new BusinessManager();
            _businessController = new BusinessController();
        }
        [Fact]
        public void Test1()
        {
            var okResult = _controller.Get();

            Assert.IsType<OkObjecttResult>(okResult.Result);
        }

        [Fact]
        public void Test2()
        {
            var okResult = _controller.Get().Result as OkObjectResult;

            var items = Assert.IsType<List<Business>>(okResult.Value);
            Assert.Equal(3, items.count);
        }
    }
}*/
