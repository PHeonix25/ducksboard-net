using System;
using System.Collections.Generic;
using Ducksboard.Model;

namespace Ducksboard
{
    public class CountersEndpoint : DucksboardEndpoint, IDucksboardEndpoint
    {
        internal CountersEndpoint() { }

        #region IDucksboardEndpoint Members

        public void Push(int id, Base request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        public void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        #endregion
    }

    public class GaugesEndpoint : DucksboardEndpoint, IDucksboardEndpoint
    {
        internal GaugesEndpoint() { }

        #region IDucksboardEndpoint Members

        public void Push(int id, Base request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request as Gauge, callback);
        }

        public void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        #endregion
    }

    public class GraphsEndpoint : DucksboardEndpoint, IDucksboardEndpoint
    {
        internal GraphsEndpoint() { }

        #region IDucksboardEndpoint Members

        public void Push(int id, Base request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request as Graph, callback);
        }

        public void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        #endregion
    }

    public class TimelinesEndpoint : DucksboardEndpoint, IDucksboardEndpoint
    {
        internal TimelinesEndpoint() { }

        #region IDucksboardEndpoint Members

        public void Push(int id, Base request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        public void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        #endregion
    }

    public class ImagesEndpoint : DucksboardEndpoint, IDucksboardEndpoint
    {
        internal ImagesEndpoint() { }

        #region IDucksboardEndpoint Members

        public void Push(int id, Base request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        public void Push(int id, IEnumerable<Base> request, Action<string, Exception, bool> callback)
        {
            base.Push(id, request, callback);
        }

        #endregion
    }
}