using System;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Foo.Bar.API.Controllers;
using Foo.Bar.API.Models.Requests;

namespace Foo.Bar.API.UnitTests.Controllers
{
    [Trait("TestType", "UnitTests")]
    public class UpdateMenuControllerTests
    {
        [Theory, AutoData]
        public async Task UpdateMenu_Returns204(Guid id, UpdateMenuRequest body)
        {
            var controller = new UpdateMenuController();
            var response = await controller.UpdateMenu(id, body);

            int? statusCode = ((StatusCodeResult)response).StatusCode;

            Assert.Equal(StatusCodes.Status204NoContent, statusCode);
        }
    }
}
