using System.Threading.Tasks;
using Example.Models.TokenAuth;
using Example.Web.Controllers;
using Shouldly;
using Xunit;

namespace Example.Web.Tests.Controllers
{
    public class HomeController_Tests: ExampleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}