using System;

namespace PerformanceCounterReader
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string Instance { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public InstanceAttribute(string instance)
        {
            Instance = instance;
        }
    }
}
