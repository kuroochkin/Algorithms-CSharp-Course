using Algorithms_CSharp_Course;
using Algorithms_DataStruct_Lib;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
    private static void Main(string[] args)
    {
        Node first = new Node() { Value = 5 };
        Node second = new Node() { Value = 1 };
        Node third = new Node() { Value = 3 };

        PrintOutLinkedList(first);

        

        Console.Read();

        
    }
    private static void PrintOutLinkedList(Node node)
    {
        while (node != null)
        {
            Console.WriteLine($"Node = {node.Value}");
            node = node.Next;
        }
    }
}