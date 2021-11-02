using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PerformanceCounterReader
{
    public class PerformanceCounterSerializer
    {
        public void Serialize(ICollection<PerformanceCounters> performanceCounters)
        {
            var flattenedCounters = new List<FlattenedCounter>();

            foreach(var c in performanceCounters)
            {
                var flattened = new FlattenedCounter(c);
                
                flattenedCounters.Add(flattened);
            }

            var json = JsonConvert.SerializeObject(flattenedCounters.OrderBy(x => x.DateTime));

            File.WriteAllText("flattened-counters.json", json);
        }
    }
}
