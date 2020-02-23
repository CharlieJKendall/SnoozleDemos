using Snoozle;
using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public class CustomModelConfiguration<TResource> : BaseModelConfiguration<TResource>, ICustomModelConfiguration
        where TResource : class, IRestResource
    {
        public string CustomModelConfigurationValue { get; set; }
    }
}
