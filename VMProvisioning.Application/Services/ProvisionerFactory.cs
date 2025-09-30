using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProvisioning.Application.Interfaces;
using VMProvisioning.Domain.Enum;
using VMProvisioning.Domain.Interfaces;

namespace VMProvisioning.Application.Services
{
    public  class ProvisionerFactory:IProvisionerFactory
    {
        private readonly IServiceProvider _sp;
        private readonly IDictionary<ProviderType, Type> _map;
        public ProvisionerFactory(IServiceProvider sp, IDictionary<ProviderType, Type> map)
        {
            _sp = sp;
            _map = map;
        }
        public IProvisioner Resolve(ProviderType provider)
        {
            if (!_map.TryGetValue(provider, out var impl))
                throw new InvalidOperationException($"No provider mapping for {provider}");

            var instance = (IProvisioner?)_sp.GetService(impl);
            return instance ?? throw new InvalidOperationException($"Provider {provider} not registered");
        }
    }
}
