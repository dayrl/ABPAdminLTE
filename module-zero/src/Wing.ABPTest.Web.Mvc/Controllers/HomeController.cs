﻿using Abp.AspNetCore.Mvc.Authorization;
using Wing.ABPTest.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Wing.ABPTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPTestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}