using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LabraryManage.Localization
{
    public static class LabraryManageLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LabraryManageConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LabraryManageLocalizationConfigurer).GetAssembly(),
                        "LabraryManage.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
