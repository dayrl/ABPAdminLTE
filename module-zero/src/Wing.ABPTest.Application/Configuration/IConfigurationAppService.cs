using System.Threading.Tasks;
using Wing.ABPTest.Configuration.Dto;

namespace Wing.ABPTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
