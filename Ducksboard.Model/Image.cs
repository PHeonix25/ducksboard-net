using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class Image : Base
    {
        [DataMember(Name = "value", Order = 2)]
        public ImageValue Value { get; set; }
    }
}