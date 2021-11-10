using System.Threading.Tasks;
using OrderFastFoot.Models.TokenAuth;
using OrderFastFoot.Web.Controllers;
using Shouldly;
using Xunit;

namespace OrderFastFoot.Web.Tests.Controllers
{
    public class HomeController_Tests: OrderFastFootWebTestBase
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