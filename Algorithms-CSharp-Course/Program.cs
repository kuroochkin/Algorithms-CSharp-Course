using Algorithms_CSharp_Course;
using Algorithms_DataStruct_Lib;
using System.Diagnostics;


int[] arr = new int[] { 4, 3, 8, 1, 5 , -5, -10, 12};

var sort = new Sorting();


var watch = new Stopwatch();
watch.Start();

Console.WriteLine("---");

watch.Stop();



Console.WriteLine($"Время выполнения: {watch.Elapsed:g}");

Console.Read();



