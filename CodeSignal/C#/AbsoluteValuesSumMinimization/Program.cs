using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using AbsoluteValuesSumMinimization.Benchmark;

var benchmarkConfiguration = ManualConfig.CreateEmpty()
    .AddColumnProvider(DefaultColumnProviders.Instance)
    .AddExporter(MarkdownExporter.Default)
    .AddLogger(ConsoleLogger.Default);

BenchmarkRunner.Run<Benchmark>(benchmarkConfiguration);