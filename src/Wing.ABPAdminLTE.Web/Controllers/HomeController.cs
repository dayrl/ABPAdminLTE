using Microsoft.AspNetCore.Mvc;

namespace Wing.ABPAdminLTE.Web.Controllers
{
    public class HomeController : ABPAdminLTEControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}