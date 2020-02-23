using Snoozle;
using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public interface ICustomRuntimeConfiguration<out TResource> : IRuntimeConfiguration
        where TResource : class, IRestResource
    {
        string CustomRuntimeConfigurationValue { get; }
    }
}