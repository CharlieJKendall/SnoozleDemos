using Snoozle;
using Snoozle.Abstractions;
using System;
using System.Collections.Generic;

namespace SnoozleDataProviderQuickstart.Implementation
{
    internal class CustomRuntimeConfigurationProvider : BaseRuntimeConfigurationProvider<ICustomRuntimeConfiguration<IRestResource>>, ICustomRuntimeConfigurationProvider
    {
        public CustomRuntimeConfigurationProvider(Dictionary<Type, ICustomRuntimeConfiguration<IRestResource>> runtimeConfigurations)
            : base(runtimeConfigurations)
        {
        }
    }
}
