using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public interface ICustomPropertyConfiguration : IPropertyConfiguration
    {
        string CustomPropertyConfigurationValue { get; set; }
    }
}
