using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OrderFastFoot.Localization
{
    public static class OrderFastFootLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OrderFastFootConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OrderFastFootLocalizationConfigurer).GetAssembly(),
                        "OrderFastFoot.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
