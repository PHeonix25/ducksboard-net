using System;
using System.Runtime.Serialization;

namespace Ducksboard.Model
{
    [DataContract]
    public abstract class Base
    {
        [DataMember(Name = "timestamp", Order = 1, EmitDefaultValue = false)]
        internal int? TimestampInternal { get; set; }

        public DateTime Timestamp
        {
            set { TimestampInternal = value.ToUnixTimestamp(); }
        }
    }
}