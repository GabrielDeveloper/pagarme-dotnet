using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateOrderItemRequest
    {
        public int Amount { get; set; }

        public string Category { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public CreateSellerRequest Seller { get; set; }

        public string SellerId { get; set; }
    }
}