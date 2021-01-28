﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateWebhookBasicAuthenticationRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
