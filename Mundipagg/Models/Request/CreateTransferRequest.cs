using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateTransferRequest
    {
        public int Amount { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}