``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                                                                  Method |         Array |          Mean |        Error |        StdDev |        Median | Rank | Allocated |
|------------------------------------------------------------------------ |-------------- |--------------:|-------------:|--------------:|--------------:|-----:|----------:|
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** | **Int32[100000]** | **223,740.73 ns** | **6,470.829 ns** | **18,773.048 ns** | **220,125.95 ns** |   **14** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo | Int32[100000] |      82.73 ns |     1.675 ns |      3.384 ns |      82.27 ns |    8 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |  **Int32[10000]** |  **20,210.25 ns** |   **400.396 ns** |    **599.294 ns** |  **20,111.37 ns** |   **13** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |  Int32[10000] |      66.64 ns |     1.330 ns |      2.747 ns |      65.98 ns |    7 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |   **Int32[1000]** |   **1,971.10 ns** |    **38.371 ns** |     **53.791 ns** |   **1,958.76 ns** |   **12** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |   Int32[1000] |      40.12 ns |     1.410 ns |      4.157 ns |      37.99 ns |    6 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |    **Int32[100]** |     **153.94 ns** |     **2.803 ns** |      **4.280 ns** |     **152.27 ns** |    **9** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |    Int32[100] |      24.59 ns |     0.376 ns |      0.334 ns |      24.56 ns |    3 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |     **Int32[10]** |      **13.04 ns** |     **0.261 ns** |      **0.422 ns** |      **12.94 ns** |    **1** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |     Int32[10] |      15.44 ns |     0.310 ns |      0.290 ns |      15.43 ns |    2 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |    **Int32[200]** |     **341.71 ns** |     **2.717 ns** |      **2.541 ns** |     **341.66 ns** |   **10** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |    Int32[200] |      28.94 ns |     0.528 ns |      0.468 ns |      28.89 ns |    4 |         - |
|      **MedirPerformanceEncontrarElementoDePicoEmComplexidadeLinearDeTempo** |    **Int32[300]** |     **527.39 ns** |     **8.449 ns** |      **8.298 ns** |     **529.46 ns** |   **11** |         **-** |
| MedirPerformanceEncontrarElementoDePicoEmComplexidadeLogaritmicaDeTempo |    Int32[300] |      32.57 ns |     0.622 ns |      0.582 ns |      32.50 ns |    5 |         - |
