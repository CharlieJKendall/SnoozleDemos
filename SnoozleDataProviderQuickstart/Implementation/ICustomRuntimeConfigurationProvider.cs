using Snoozle;
using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public interface ICustomRuntimeConfigurationProvider : IRuntimeConfigurationProvider<ICustomRuntimeConfiguration<IRestResource>>
    {
    }
}
