using System.Threading.Tasks;
using MyProjectImpulso.Models.TokenAuth;
using MyProjectImpulso.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyProjectImpulso.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProjectImpulsoWebTestBase
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