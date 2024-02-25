using System.Threading.Tasks;
using LabraryManage.Models.TokenAuth;
using LabraryManage.Web.Controllers;
using Shouldly;
using Xunit;

namespace LabraryManage.Web.Tests.Controllers
{
    public class HomeController_Tests: LabraryManageWebTestBase
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