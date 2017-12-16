using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wing.ABPAdminLTE.Controllers;

namespace Wing.ABPAdminLTE.Web.Mvc.Controllers
{
    public class AccountController : ABPAdminLTEControllerBase
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}