using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProvisioning.Domain.Enum;

namespace VMProvisioning.Domain.Entities
{
        public  record ProvisionRequest
            (
            ProviderType Provider,
            string Name,
            IDictionary<string, object>? Parameters,
            IDictionary<string, string>? SensitiveParameters
            );
}
