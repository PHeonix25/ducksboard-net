using System;
using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class ImageValue
    {
        public byte[] SourceBytes
        {
            set { Source = "data:image/png;base64," + Convert.ToBase64String(value); }
        }

        [DataMember(Name = "source", Order = 1)]
        public string Source { get; set; }

        [DataMember(Name = "caption", Order = 2)]
        public string Caption { get; set; }
    }
}