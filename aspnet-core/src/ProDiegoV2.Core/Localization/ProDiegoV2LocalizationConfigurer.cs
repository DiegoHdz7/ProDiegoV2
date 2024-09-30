using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProDiegoV2.Localization
{
    public static class ProDiegoV2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProDiegoV2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProDiegoV2LocalizationConfigurer).GetAssembly(),
                        "ProDiegoV2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
