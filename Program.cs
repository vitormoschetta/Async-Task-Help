using System.Diagnostics;
using Teste;

var stopwatch = new Stopwatch();
stopwatch.Start();

//Sample0.Execute();
//Sample1.Execute();
//Sample2.Execute();
//Sample3.Execute();
//Sample4.Execute();
//Sample5.Execute();
//await Sample6.Execute();
await Sample7.Execute();


stopwatch.Stop();
Console.WriteLine("Tempo total: {0}", stopwatch.Elapsed);