using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class Graph : Base
    {
        [DataMember(Name = "value", Order = 2)]
        public int Value { get; set; }
    }
}