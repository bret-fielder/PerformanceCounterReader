using System;

namespace PerformanceCounterReader
{
    public class FlattenedCounter
    {
        public FlattenedCounter(PerformanceCounters c)
        {
            DateTime = c.DateTime;
            MonacoProcessorTime = c.Values[0];
            MonacoThreadCount = c.Values[1];
            MonacoPrivateBytes = c.Values[2];
            ClrBytes = c.Values[3];
            GdkProcessorTime = c.Values[4];
            GdkThreadCount = c.Values[5];
            GdkPrivateBytes = c.Values[6];
        }

        public DateTime DateTime { get; set; }
        public double MonacoProcessorTime { get; set; }
        public double MonacoThreadCount { get; set; }
        public double MonacoPrivateBytes { get; set; }
        public double ClrBytes { get; set; }
        public double GdkProcessorTime { get; set; }
        public double GdkThreadCount { get; set; }
        public double GdkPrivateBytes { get; set; }

    }
}
