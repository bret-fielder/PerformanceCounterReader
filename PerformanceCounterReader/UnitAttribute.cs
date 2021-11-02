using System;

namespace PerformanceCounterReader
{
    /// <summary>
    /// 
    /// </summary>
    public class UnitAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string Unit { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        public UnitAttribute(string unit)
        {
            Unit = unit;
        }
    }
}
