using System.Threading.Tasks;
using App.ExemploMvc.Models.TokenAuth;
using App.ExemploMvc.Web.Controllers;
using Shouldly;
using Xunit;

namespace App.ExemploMvc.Web.Tests.Controllers
{
    public class HomeController_Tests: ExemploMvcWebTestBase
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