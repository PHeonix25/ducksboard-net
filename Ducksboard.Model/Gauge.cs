using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class Gauge : Base
    {
        [DataMember(Name = "value", Order = 2)]
        public float Value { get; set; }
    }
}