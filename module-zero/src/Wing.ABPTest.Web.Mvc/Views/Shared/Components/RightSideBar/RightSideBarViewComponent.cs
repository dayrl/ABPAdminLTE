using System.Linq;
using System.Threading.Tasks;
using Abp.Configuration;
using Wing.ABPTest.Configuration;
using Wing.ABPTest.Configuration.Ui;
using Microsoft.AspNetCore.Mvc;

namespace Wing.ABPTest.Web.Views.Shared.Components.RightSideBar
{
    public class RightSideBarViewComponent : ABPTestViewComponent
    {
        private readonly ISettingManager _settingManager;

        public RightSideBarViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var themeName = await _settingManager.GetSettingValueAsync(AppSettingNames.UiTheme);

            var viewModel = new RightSideBarViewModel
            {
                CurrentTheme = UiThemes.All.FirstOrDefault(t => t.CssClass == themeName)
            };

            return View(viewModel);
        }
    }
}
