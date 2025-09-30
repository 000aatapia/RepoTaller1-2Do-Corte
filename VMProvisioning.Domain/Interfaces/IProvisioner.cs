using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProvisioning.Domain.Entities;

namespace VMProvisioning.Domain.Interfaces
{
    public interface IProvisioner
    {
        Task<ProvisionResult> ProvisionAsnyc(ProvisionRequest request);
        string ProviderName { get; }
    }
}
