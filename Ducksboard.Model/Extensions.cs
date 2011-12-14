using System;

namespace Ducksboard.Model
{
    internal static class Extensions
    {
        public static int ToUnixTimestamp(this DateTime dateTime)
        {
            return (int) Math.Floor((double) (dateTime.Ticks - (new DateTime(1970, 1, 1, 0, 0, 0)).Ticks)/10000000);
        }

        public static DateTime FromUnixTimestamp(int timestamp)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(timestamp);
        }
    }
}