using System;
using System.Collections.Generic;
using System.IO;
using Ducksboard.Model;

namespace Ducksboard.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Api.Init("APIKEY");

            TestPushCounter(1);
            //TestPushGauge(2);
            //TestPushGraph(3);
            //TestPushTimeline(4);
            //TestPushImage(5);

            System.Console.Read();
        }

        private static void TestPushCounter(int id)
        {
            System.Console.WriteLine("Push Counter -> BEGIN");
            var counter = new Counter { Value = 344 };
            Api.Counters.Push(id, counter, (result, error, cancelled) => System.Console.WriteLine("Push Counter -> END"));
        }

        private static void TestPushGauge(int id)
        {
            System.Console.WriteLine("Push Gauge -> BEGIN");
            var gauge = new Gauge { Value = 0.3f };
            Api.Gauges.Push(id, gauge, (result, error, cancelled) => System.Console.WriteLine("Push Gauge -> END"));
        }

        private static void TestPushGraph(int id)
        {
            System.Console.WriteLine("Push Gauge -> BEGIN");
            var graph1 = new Graph { Timestamp = DateTime.UtcNow.Subtract(TimeSpan.FromHours(10)), Value = 345 };
            var graph2 = new Graph { Timestamp = DateTime.UtcNow, Value = 500 };
            Api.Graphs.Push(id, new[] { graph1, graph2 },
                            (result, error, cancelled) => System.Console.WriteLine("Push Gauge -> END"));
        }

        private static void TestPushTimeline(int id)
        {
            System.Console.WriteLine("Push Timeline -> BEGIN");
            var timeline1 = new Timeline
            {
                //Timestamp = DateTime.UtcNow.ToUnixTimestamp(),
                Value = new TimelineValue
                {
                    Content = "Hey",
                    ImageUrl = TimelineValue.DefaultImageUrlRed,
                    Title = "Test"
                }
            };
            var timeline2 = new Timeline
            {
                Timestamp = DateTime.UtcNow,
                Value = new TimelineValue
                {
                    Content = "Hey",
                    ImageUrl = TimelineValue.DefaultImageUrlRed,
                    Title = "Test"
                }
            };
            Api.Timelines.Push(id, new List<Timeline> { timeline1, timeline2 },
                               (result, error, cancelled) => System.Console.WriteLine("Push Timeline -> END"));
        }

        private static void TestPushImage(int id)
        {
            System.Console.WriteLine("Push Image -> BEGIN");
            var image1 = new Image
            {
                Value = new ImageValue
                {
                    Caption = "Some caption",
                    Source = "https://app.ducksboard.com/static/accounts/img/logo_small.png"
                }
            };
            var image2 = new Image
            {
                Value = new ImageValue
                {
                    Caption = "Some caption",
                    SourceBytes = File.ReadAllBytes("logo_small.png")
                }
            };
            Api.Images.Push(id, new[] { image1, image2 },
                            (result, error, cancelled) => System.Console.WriteLine("Push Image -> END"));
        }
    }
}