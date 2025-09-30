using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMProvisioning.Domain.Entities
{
    public record ProvisionResult
        (
            bool Succes,
            string? ResourceId,
            string? ErrorMessage
        );
}
