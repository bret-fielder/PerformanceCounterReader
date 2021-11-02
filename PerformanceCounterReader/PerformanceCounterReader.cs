using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PerformanceCounterReader
{
    public class PerformanceCounterReader
    {
        public ICollection<PerformanceCounters> DeserializeFiles(string path)
        {
            var result = new List<PerformanceCounters>();

            var filenames = Directory.GetFiles(path, "*.bin");

            foreach(var filename in filenames)
            {
                try
                {
                    var deserializedFile = DeserializeFile(filename);
                    result.AddRange(deserializedFile);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Problem with {filename} : {ex.Message}");
                    continue;
                }
            }

            return result;
        }

        public ICollection<PerformanceCounters> DeserializeFile(string fileName)
        {
            var result = new List<PerformanceCounters>();

            using (var inputStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var binder = new CustomSerializationBinder();

                var formatter = new BinaryFormatter();
                formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                formatter.TypeFormat = System.Runtime.Serialization.Formatters.FormatterTypeStyle.TypesWhenNeeded;
                formatter.Binder = binder;

                while (inputStream.Position < inputStream.Length)
                {
                    var deserialized = formatter.Deserialize(inputStream);
                        
                    var pc = (PerformanceCounters)deserialized;

                    result.Add(pc);
                }                
            }

            return result;
        }
    }
}
