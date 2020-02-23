using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public interface ICustomModelConfiguration : IModelConfiguration
    {
        string CustomModelConfigurationValue { get; set; }
    }
}