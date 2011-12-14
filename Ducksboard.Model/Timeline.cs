using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public class Timeline : Base
    {
        [DataMember(Name = "value", Order = 2)]
        public TimelineValue Value { get; set; }
    }
}