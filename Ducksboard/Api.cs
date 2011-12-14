namespace Ducksboard
{
    public class Api
    {
        private static CountersEndpoint _countersEndpoint;

        private static GaugesEndpoint _gaugesEndpoint;

        private static GraphsEndpoint _graphsEndpoint;

        private static TimelinesEndpoint _timelineEndpoint;

        private static ImagesEndpoint _imagesEndpoint;

        public static CountersEndpoint Counters
        {
            get { return _countersEndpoint ?? (_countersEndpoint = new CountersEndpoint()); }
        }

        public static GaugesEndpoint Gauges
        {
            get { return _gaugesEndpoint ?? (_gaugesEndpoint = new GaugesEndpoint()); }
        }

        public static GraphsEndpoint Graphs
        {
            get { return _graphsEndpoint ?? (_graphsEndpoint = new GraphsEndpoint()); }
        }

        public static TimelinesEndpoint Timelines
        {
            get { return _timelineEndpoint ?? (_timelineEndpoint = new TimelinesEndpoint()); }
        }

        public static ImagesEndpoint Images
        {
            get { return _imagesEndpoint ?? (_imagesEndpoint = new ImagesEndpoint()); }
        }

        public static void Init(string apiKey)
        {
            DucksboardClient.Init(apiKey);
        }
    }
}