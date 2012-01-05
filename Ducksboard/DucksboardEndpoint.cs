using System;
using System.Net;
using Newtonsoft.Json;

namespace Ducksboard
{
    public abstract class DucksboardEndpoint
    {
        private static DucksboardClient Client { get { return DucksboardClient.Instance; } }

        protected void Push(int id, object obj, Action<string, Exception, bool> callback)
        {
            Client.UploadStringCompleted += (sender, e) => {
                callback(e.Result, e.Error, e.Cancelled);
                Client.UploadStringCompleted -= (sender as UploadStringCompletedEventHandler);
            };
            var json = JsonConvert.SerializeObject(obj, Formatting.None, Client.JsonSerializerSettings);
            //Console.WriteLine(json);
            Client.UploadStringAsync(new Uri(Client.BaseAddress + id + "/"), json);
        }
    }
}