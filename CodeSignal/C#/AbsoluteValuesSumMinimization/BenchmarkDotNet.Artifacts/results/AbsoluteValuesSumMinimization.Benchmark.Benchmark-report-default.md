
BenchmarkDotNet v0.13.11, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-7300HQ CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


 Method                                              | Mean           | Error         | StdDev        | Rank | Gen0    | Allocated |
---------------------------------------------------- |---------------:|--------------:|--------------:|-----:|--------:|----------:|
 AbsoluteValuesSumMinimization_BestSolution          |       1.462 ns |     0.0147 ns |     0.0131 ns |    1 |       - |         - |
 AbsoluteValuesSumMinimization_NaiveButALittleBetter | 305,836.644 ns | 1,889.1634 ns | 1,767.1246 ns |    2 |       - |         - |
 AbsoluteValuesSumMinimization_Naive                 | 327,889.460 ns | 2,377.3954 ns | 2,223.8171 ns |    3 |       - |         - |
 AbsoluteValuesSumMinimization_SecondAttempt         | 533,179.136 ns | 2,308.5674 ns | 2,046.4848 ns |    4 | 13.6719 |   45480 B |
 AbsoluteValuesSumMinimization_Linq                  | 539,166.279 ns | 2,553.4424 ns | 2,388.4916 ns |    4 | 16.6016 |   54808 B |
