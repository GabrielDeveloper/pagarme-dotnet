using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePhonesRequest
    {
        public CreatePhoneRequest HomePhone { get; set; }

        public CreatePhoneRequest MobilePhone { get; set; }
    }
}