using System;
using System.Collections.Generic;
using Ducksboard.Model;

namespace Ducksboard
{
    internal interface IDucksboardEndpoint
    {
        void Push(int id, Base request, Action<string, Exception, bool> callback);
        void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback);
    }
}