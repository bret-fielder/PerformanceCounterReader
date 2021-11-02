namespace PerformanceCounterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = args[0];

            var deserializer = new PerformanceCounterReader();

            var deserialized = deserializer.DeserializeFiles(folder);

            var serializer = new PerformanceCounterSerializer();

            serializer.Serialize(deserialized);
        }
    }
}
