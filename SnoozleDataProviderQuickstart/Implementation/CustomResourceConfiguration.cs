using Snoozle;
using Snoozle.Abstractions;
using System.Collections.Generic;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public class CustomResourceConfiguration<TResource> : BaseResourceConfiguration<TResource, ICustomPropertyConfiguration, ICustomModelConfiguration>, ICustomResourceConfiguration
        where TResource : class, IRestResource
    {
        public CustomResourceConfiguration(
            ICustomModelConfiguration modelConfiguration,
            IEnumerable<ICustomPropertyConfiguration> propertyConfigurations)
            : base(modelConfiguration, propertyConfigurations)
        {
        }
    }
}
