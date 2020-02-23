using Snoozle;
using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    internal class CustomRuntimeConfiguration<TResource> : BaseRuntimeConfiguration<ICustomPropertyConfiguration, ICustomModelConfiguration, TResource>, ICustomRuntimeConfiguration<TResource>
        where TResource : class, IRestResource
    {
        // This is created by reflection, so be careful when changing/adding parameters
        public CustomRuntimeConfiguration(ICustomResourceConfiguration resourceConfiguration)
            : base(resourceConfiguration)
        {
        }

        public string CustomRuntimeConfigurationValue { get; }
    }
}
