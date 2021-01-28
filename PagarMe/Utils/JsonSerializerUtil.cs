﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Utils
{
    /// <summary>
    /// Custom json serializer
    /// </summary>
    public class JsonSerializerUtil
    {
        /// <summary>
        /// Snake case settings
        /// </summary>
        public static JsonSerializerSettings SnakeCaseSettings
        {
            get
            {
                var settings = new JsonSerializerSettings();

                settings.ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };
                settings.Formatting = Formatting.Indented;
                settings.Converters.Add(new StringEnumConverter());
                settings.NullValueHandling = NullValueHandling.Ignore;

                return settings;
            }
        }
    }

    /// <summary>
    /// Resolve property names to lowercase only
    /// </summary>
    public class LowerCaseNamingResolver : NamingStrategy
    {
        #region Protected Methods

        protected override string ResolvePropertyName(string name)
        {
            return name.ToLower();
        }

        #endregion Protected Methods
    }
}