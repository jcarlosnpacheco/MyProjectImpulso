using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyProjectImpulso.Localization
{
    public static class MyProjectImpulsoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyProjectImpulsoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyProjectImpulsoLocalizationConfigurer).GetAssembly(),
                        "MyProjectImpulso.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
