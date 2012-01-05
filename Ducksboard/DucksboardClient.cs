using System;
using System.Net;
using Newtonsoft.Json;

namespace Ducksboard
{
    internal class DucksboardClient : WebClient
    {
        private static string _apiKey;

        private static DucksboardClient _ducksboardClient;
        internal static DucksboardClient Instance
        {
            get { return _ducksboardClient ?? (_ducksboardClient = new DucksboardClient()); }
        }

        public JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings {
            Error = (sender, e) => { throw e.ErrorContext.Error; },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore
        };

        private DucksboardClient()
        {
            BaseAddress = "https://push.ducksboard.com/values/";
            Credentials = new CredentialCache { { new Uri(BaseAddress), "Basic", new NetworkCredential(_apiKey, "~") } };
        }

        internal static void Init(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}