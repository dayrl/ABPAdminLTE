using System.Collections.Generic;

namespace Wing.ABPAdminLTE.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
