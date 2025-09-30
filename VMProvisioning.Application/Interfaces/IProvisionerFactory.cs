using VMProvisioning.Domain.Enum;
using VMProvisioning.Domain.Interfaces;

namespace VMProvisioning.Application.Interfaces
{
    public interface IProvisionerFactory
    {
        IProvisioner Resolve(ProviderType provider);
    }
}

