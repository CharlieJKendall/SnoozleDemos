using Snoozle.Abstractions;

namespace SnoozleDataProviderQuickstart.Implementation
{
    public class CustomModelConfigurationBuilder : BaseModelConfigurationBuilder<ICustomModelConfiguration>, IModelConfigurationBuilder<ICustomModelConfiguration>
    {
        public CustomModelConfigurationBuilder(ICustomModelConfiguration modelConfiguration)
            : base(modelConfiguration)
        {
        }
    }
}