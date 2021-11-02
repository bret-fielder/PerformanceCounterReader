using System;

namespace PerformanceCounterReader
{
    /// <summary>
    /// 
    /// </summary>
    public class CounterTypeAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string CounterType { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public CounterTypeAttribute(string type)
        {
            CounterType = type;
        }
    }
}
