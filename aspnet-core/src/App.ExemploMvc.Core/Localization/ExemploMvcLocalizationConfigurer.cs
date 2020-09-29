using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace App.ExemploMvc.Localization
{
    public static class ExemploMvcLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ExemploMvcConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ExemploMvcLocalizationConfigurer).GetAssembly(),
                        "App.ExemploMvc.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
