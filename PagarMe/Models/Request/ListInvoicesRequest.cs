﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListInvoicesRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public string Status { get; set; }

        public string SubscriptionId { get; set; }
    }
}