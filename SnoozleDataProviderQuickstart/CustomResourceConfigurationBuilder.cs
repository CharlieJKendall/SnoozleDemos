using Snoozle;
using Snoozle.Abstractions;
using SnoozleDataProviderQuickstart.Implementation;

namespace SnoozleDataProviderQuickstart
{
    public abstract class CustomResourceConfigurationBuilder<TResource> : BaseResourceConfigurationBuilder<TResource, ICustomPropertyConfiguration, ICustomResourceConfiguration, ICustomModelConfiguration>
        where TResource : class, IRestResource
    {
        protected override IPropertyConfigurationBuilder<TProperty, ICustomPropertyConfiguration> CreatePropertyConfigurationBuilder<TProperty>(
            ICustomPropertyConfiguration propertyConfiguration)
        {
            return new CustomPropertyConfigurationBuilder<TResource, TProperty>(propertyConfiguration);
        }

        protected override ICustomResourceConfiguration CreateResourceConfiguration()
        {
            return new CustomResourceConfiguration<TResource>(ModelConfiguration, PropertyConfigurations);
        }

        protected override ICustomModelConfiguration CreateModelConfiguration()
        {
            return new CustomModelConfiguration<TResource>();
        }

        protected override ICustomPropertyConfiguration CreatePropertyConfiguration()
        {
            return new CustomPropertyConfiguration();
        }

        protected override IModelConfigurationBuilder<ICustomModelConfiguration> CreateModelConfigurationBuilder()
        {
            return new CustomModelConfigurationBuilder(ModelConfiguration);
        }

        protected override void SetPropertyConfigurationDefaults()
        {
            base.SetPropertyConfigurationDefaults();
        }
    }
}
