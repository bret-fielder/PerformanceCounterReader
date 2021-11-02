using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace PerformanceCounterReader
{
    public class CustomSerializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            assemblyName = Assembly.GetExecutingAssembly().FullName;

            typeName = "PerformanceCounterReader.PerformanceCounters";
            
            var typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));

            return typeToDeserialize;
        }
    }
}
