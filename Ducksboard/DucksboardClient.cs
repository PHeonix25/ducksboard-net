using System;
using System.Net;
using Newtonsoft.Json;

namespace Ducksboard
{
    internal class DucksboardClient : WebClient
    {
        private static string _apiKey;
        private readonly CredentialCache _credentialCache;

        public JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings {
            Error = (sender, e) => { throw e.ErrorContext.Error; },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore
        };

        public DucksboardClient()
        {
            BaseAddress = "https://push.ducksboard.com/values/";
            _credentialCache = new CredentialCache {{new Uri(BaseAddress), "Basic", new NetworkCredential(_apiKey, "~")}};
            Credentials = _credentialCache;
        }

        internal static void Init(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}