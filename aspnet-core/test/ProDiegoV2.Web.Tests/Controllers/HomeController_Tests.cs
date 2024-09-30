using System.Threading.Tasks;
using ProDiegoV2.Models.TokenAuth;
using ProDiegoV2.Web.Controllers;
using Shouldly;
using Xunit;

namespace ProDiegoV2.Web.Tests.Controllers
{
    public class HomeController_Tests: ProDiegoV2WebTestBase
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