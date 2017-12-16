using Microsoft.AspNetCore.Mvc;

namespace Wing.ABPAdminLTE.Web.Controllers
{
    public class HomeController : ABPAdminLTEControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}