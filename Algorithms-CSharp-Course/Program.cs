using Algorithms_CSharp_Course;
using Algorithms_DataStruct_Lib;
using System.Diagnostics;

var ints = In.ReadInts("kkk.txt").ToArray();

var watch = new Stopwatch();
watch.Start();

var triplets = ThreeSum.Count(ints);

watch.Stop();

Console.WriteLine($"Количество триплетов равных нулю: {triplets}");
Console.WriteLine($"Время выполнения: {watch.Elapsed:g}");

Console.Read();



