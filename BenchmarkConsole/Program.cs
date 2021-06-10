using BenchmarkDotNet.Running;
using System;

namespace BenchmarkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NameParserBenchmark>();
        }
    }
}
