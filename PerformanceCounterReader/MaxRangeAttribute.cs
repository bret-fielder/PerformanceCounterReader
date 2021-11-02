using System;

namespace PerformanceCounterReader
{
    public class MaxRangeAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public int MaxRange { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxRange"></param>
        public MaxRangeAttribute(int maxRange)
        {
            MaxRange = maxRange;
        }
    }
}
