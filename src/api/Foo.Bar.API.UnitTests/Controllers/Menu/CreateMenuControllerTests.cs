using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Foo.Bar.API.Controllers;
using Foo.Bar.API.Models.Requests;
using Foo.Bar.API.Models.Responses;

namespace Foo.Bar.API.UnitTests.Controllers
{
    [Trait("TestType", "UnitTests")]
    public class CreateMenuControllerTests
    {
        [Theory, AutoData]
        public async Task CreateMenu_ReturnsCreatedAtActionResult(CreateMenuRequest body)
        {
            var controller = new CreateMenuController();
            var response = await controller.CreateMenu(body);

            Assert.IsType<CreatedAtActionResult>(response);
            var content = (CreatedAtActionResult)response;
            Assert.Equal("GetMenu", content.ActionName);
            Assert.Equal("GetMenuById", content.ControllerName);
            Assert.Equal("GetMenuById", content.ControllerName);
            Assert.IsType<ResourceCreatedResponse>(content.Value);
        }
    }
}
