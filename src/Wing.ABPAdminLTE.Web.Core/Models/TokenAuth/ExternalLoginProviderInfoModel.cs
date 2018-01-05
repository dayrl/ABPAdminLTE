using Abp.AutoMapper;
using Wing.ABPAdminLTE.Authentication.External;

namespace Wing.ABPAdminLTE.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
