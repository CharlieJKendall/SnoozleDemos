using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public class CustomPropertyConfiguration : BasePropertyConfiguration, ICustomPropertyConfiguration
    {
        public string CustomPropertyConfigurationValue { get; set; }
    }
}
