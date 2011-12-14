using System;
using System.Net;
using Newtonsoft.Json;

namespace Ducksboard
{
    public abstract class DucksboardEndpoint
    {
        private DucksboardClient _ducksboardClient;

        internal DucksboardEndpoint()
        {
        }

        protected void Push(int id, object obj, Action<string, Exception, bool> callback)
        {
            if (_ducksboardClient == null)
                _ducksboardClient = new DucksboardClient();

            _ducksboardClient.UploadStringCompleted += (sender, e) => {
                callback(e.Result, e.Error, e.Cancelled);
                _ducksboardClient.UploadStringCompleted -= (sender as UploadStringCompletedEventHandler);
            };
            string json = JsonConvert.SerializeObject(obj, Formatting.None, _ducksboardClient.JsonSerializerSettings);
            //Console.WriteLine(json);
            _ducksboardClient.UploadStringAsync(new Uri(_ducksboardClient.BaseAddress + id + "/"), json);
        }
    }
}