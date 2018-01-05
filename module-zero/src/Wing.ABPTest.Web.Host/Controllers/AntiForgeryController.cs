using Microsoft.AspNetCore.Antiforgery;
using Wing.ABPTest.Controllers;

namespace Wing.ABPTest.Web.Host.Controllers
{
    public class AntiForgeryController : ABPTestControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
