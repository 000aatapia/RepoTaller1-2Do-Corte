using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using VMProvisioning.Domain.Enum;

namespace VMProvisioning.Application.DTOs
{
    public class ProvisionRequestDto
    {
        [JsonPropertyName("provider")] public ProviderType Provider { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
        [JsonPropertyName("parameters")] public Dictionary<string, object>? Parameters { get; set; }
        [JsonPropertyName("sensitiveParameters")] public Dictionary<string, string>? SensitiveParameters { get; set; }
    }
}
