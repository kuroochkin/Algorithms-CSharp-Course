using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Algorithms_CSharp_Course
{
    public class ListDemo
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);

            for(int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }

            for(int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            Console.Read();
        }

        public static void ApiMembers()
        {
            var list = new List<int>() { 1, 0, 5, 3, 4 };
            list.Sort();
        }

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count = {list.Count}. Capacity = {list.Capacity}");
        }
    }
}
