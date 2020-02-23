using Snoozle.Abstractions;
using Snoozle.Exceptions;
using SnoozleDataProviderQuickstart.Implementation;

namespace SnoozleDataProviderQuickstart
{
    public static class ModelConfigurationBuilderExtensions
    {
        public static IModelConfigurationBuilder<ICustomModelConfiguration> HasCustomModelConfigurationValue(
            this IModelConfigurationBuilder<ICustomModelConfiguration> @this,
            string customModelConfigurationValue)
        {
            ExceptionHelper.ArgumentNull.ThrowIfNecessary(customModelConfigurationValue, nameof(customModelConfigurationValue));

            @this.ModelConfiguration.CustomModelConfigurationValue = customModelConfigurationValue;

            return @this;
        }
    }

    public static class PropertyConfigurationBuilderExtensions
    {
        public static IPropertyConfigurationBuilder<TProperty, ICustomPropertyConfiguration> HasCustomPropertConfigurationValue<TProperty>(
            this IPropertyConfigurationBuilder<TProperty, ICustomPropertyConfiguration> @this,
            string customPropertConfigValue)
        {
            ExceptionHelper.ArgumentNull.ThrowIfNecessary(customPropertConfigValue, nameof(customPropertConfigValue));

            @this.PropertyConfiguration.CustomPropertyConfigurationValue = customPropertConfigValue;

            return @this;
        }
    }
}
