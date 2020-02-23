using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Snoozle;
using Snoozle.Abstractions;
using SnoozleDataProviderQuickstart.Configuration;
using SnoozleDataProviderQuickstart.Implementation;
using System;
using System.Collections.Generic;

namespace SnoozleDataProviderQuickstart
{
    public static class ServiceCollectionExtensions
    {
        // Called from startup.cs
        public static IMvcBuilder AddSnoozleCustomDataProvider(this IMvcBuilder @this, IConfigurationSection configurationSection)
        {
            @this.Services.Configure<CustomUserConfiguration>(options => configurationSection.Bind(options));

            return AddSnoozleCustomDataProvider(@this);
        }

        // Called from startup.cs
        public static IMvcBuilder AddSnoozleCustomDataProvider(this IMvcBuilder @this, Action<CustomUserConfiguration> optionsBuilder)
        {
            @this.Services.Configure(optionsBuilder);

            return AddSnoozleCustomDataProvider(@this);
        }

        private static IMvcBuilder AddSnoozleCustomDataProvider(this IMvcBuilder @this)
        {
            IServiceCollection serviceCollection = @this.Services;
            ICustomRuntimeConfigurationProvider runtimeConfigurationProvider = BuildRuntimeConfigurationProvider();

            serviceCollection.AddScoped<IDataProvider, CustomDataProvider>();
            serviceCollection.AddSingleton(runtimeConfigurationProvider);

            @this.AddSnoozleCore(runtimeConfigurationProvider);

            return @this;
        }

        private static ICustomRuntimeConfigurationProvider BuildRuntimeConfigurationProvider()
        {
            IEnumerable<ICustomResourceConfiguration> resourceConfigurations =
                ResourceConfigurationBuilder.Build<ICustomPropertyConfiguration, ICustomResourceConfiguration, ICustomModelConfiguration>(typeof(CustomResourceConfigurationBuilder<>));

            var runtimeConfigurations = new Dictionary<Type, ICustomRuntimeConfiguration<IRestResource>>();

            // Create a runtime configuration for each resource type and pass it to a runtime configuration provider instance to be registered with the DI container
            foreach (ICustomResourceConfiguration configuration in resourceConfigurations)
            {
                var runtimeConfiguration = Activator.CreateInstance(
                    typeof(CustomRuntimeConfiguration<>).MakeGenericType(configuration.ResourceType),
                    configuration) as ICustomRuntimeConfiguration<IRestResource>;

                runtimeConfigurations.Add(configuration.ResourceType, runtimeConfiguration);
            }

            return new CustomRuntimeConfigurationProvider(runtimeConfigurations);
        }
    }
}