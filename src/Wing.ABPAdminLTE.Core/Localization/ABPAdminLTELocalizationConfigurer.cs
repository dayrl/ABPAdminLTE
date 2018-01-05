using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Wing.ABPAdminLTE.Localization
{
    public static class ABPAdminLTELocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPAdminLTEConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPAdminLTELocalizationConfigurer).GetAssembly(),
                        "Wing.ABPAdminLTE.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
