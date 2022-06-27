using System.Threading.Tasks;
using company.Models.TokenAuth;
using company.Web.Controllers;
using Shouldly;
using Xunit;

namespace company.Web.Tests.Controllers
{
    public class HomeController_Tests: companyWebTestBase
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