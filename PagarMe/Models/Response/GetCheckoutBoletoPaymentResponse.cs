using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace PagarMe.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutBoletoPaymentResponse
    {
        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }
    }
}