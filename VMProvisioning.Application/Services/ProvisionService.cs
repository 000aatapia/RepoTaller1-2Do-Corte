using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMProvisioning.Application.Interfaces;
using VMProvisioning.Domain.Enum;
using VMProvisioning.Domain.Entities;

namespace VMProvisioning.Application.Services
{
    public class ProvisionService
    {
        private readonly IProvisionerFactory _factory;
        private readonly ILogger<ProvisionService> _logger;
        public ProvisionService(IProvisionerFactory factory, ILogger<ProvisionService> logger)
        {
            _factory = factory;
            _logger =  logger;
        }
        public async Task<ProvisionResult> ProvisionAsync(ProvisionRequest request )
        {
            _logger.LogInformation("Provision request for {Provider}", request.Provider);

            var provisioner = _factory.Resolve(request.Provider);
            try
            {
                return await provisioner.ProvisionAsnyc(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error provisioning VM");
                return new ProvisionResult(false, null, "Internal error: " + ex.Message);
            }
        }
    }
}
