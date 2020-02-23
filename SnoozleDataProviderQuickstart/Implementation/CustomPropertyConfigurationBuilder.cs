using Snoozle;
using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public class CustomPropertyConfigurationBuilder<TResource, TProperty> : BasePropertyConfigurationBuilder<TResource, TProperty, ICustomPropertyConfiguration>, IPropertyConfigurationBuilder<TProperty, ICustomPropertyConfiguration>
        where TResource : class, IRestResource
    {
        public CustomPropertyConfigurationBuilder(ICustomPropertyConfiguration propertyConfiguration)
            : base(propertyConfiguration)
        {
        }
    }
}
