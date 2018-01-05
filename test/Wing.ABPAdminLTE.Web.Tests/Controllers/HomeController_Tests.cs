using System.Threading.Tasks;
using Wing.ABPAdminLTE.Web.Controllers;
using Shouldly;
using Xunit;

namespace Wing.ABPAdminLTE.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPAdminLTEWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
