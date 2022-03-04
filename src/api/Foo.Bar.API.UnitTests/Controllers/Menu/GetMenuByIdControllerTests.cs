using System;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Foo.Bar.API.Controllers;
using Foo.Bar.API.Models.Responses;

namespace Foo.Bar.API.UnitTests.Controllers
{
    [Trait("TestType", "UnitTests")]
    public class GetMenuByIdControllerTests
    {
        [Theory, AutoData]
        public async Task GetMenu_Returns200_AndMenu(Guid id)
        {
            var controller = new GetMenuByIdController();
            var response = await controller.GetMenu(id);

            var content = ((ObjectResult)response).Value;
            Assert.IsType<Menu>(content);
        }
    }
}
