using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateBankAccountRequest
    {
        public string AccountCheckDigit { get; set; }

        public string AccountNumber { get; set; }

        public string Bank { get; set; }

        public string BranchCheckDigit { get; set; }

        public string BranchNumber { get; set; }

        public string HolderDocument { get; set; }

        public string HolderName { get; set; }

        public string HolderType { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Type { get; set; }
    }
}