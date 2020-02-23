using Snoozle;
using Snoozle.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnoozleDataProviderQuickstart.Implementation
{
    internal class CustomDataProvider : IDataProvider
    {
        private readonly ICustomRuntimeConfigurationProvider _customRuntimeConfigurationProvider;

        public CustomDataProvider(ICustomRuntimeConfigurationProvider customRuntimeConfigurationProvider)
        {
            _customRuntimeConfigurationProvider = customRuntimeConfigurationProvider;
        }

        public Task<bool> DeleteByIdAsync<TResource>(object primaryKey)
            where TResource : class, IRestResource
        {
            var config = GetConfig<TResource>();

            throw new NotImplementedException();
        }

        public Task<TResource> InsertAsync<TResource>(TResource resourceToCreate)
            where TResource : class, IRestResource
        {
            var config = GetConfig<TResource>();

            throw new NotImplementedException();
        }

        public Task<IEnumerable<TResource>> SelectAllAsync<TResource>()
            where TResource : class, IRestResource
        {
            var config = GetConfig<TResource>();

            throw new NotImplementedException();
        }

        public Task<TResource> SelectByIdAsync<TResource>(object primaryKey)
            where TResource : class, IRestResource
        {
            var config = GetConfig<TResource>();

            throw new NotImplementedException();
        }

        public Task<TResource> UpdateAsync<TResource>(TResource resourceToUpdate, object primaryKey)
            where TResource : class, IRestResource
        {
            var config = GetConfig<TResource>();

            throw new NotImplementedException();
        }

        private ICustomRuntimeConfiguration<TResource> GetConfig<TResource>()
            where TResource : class, IRestResource
        {
            return (ICustomRuntimeConfiguration<TResource>)_customRuntimeConfigurationProvider.GetRuntimeConfigurationForType(typeof(TResource));
        }
    }
}
