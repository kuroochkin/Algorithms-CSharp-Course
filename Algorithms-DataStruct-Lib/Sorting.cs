using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib
{
    public class Sorting
    {
        // Пузырьковая сортировка
        // Использует малое кол-во памяти("In-place" алгоритм)
        // Стабильный
        // Квадратичная сложность(быстрая деградация)
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for(int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largest = 0;

                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[largest] < array[i])
                        largest = i;
                }   
                Swap(array, largest, partIndex);
            }
        }

        // Сортировка вставками
        // Использует малое кол-во памяти("In-place" алгоритм)
        // Cтабильный
        // Квадратичная сложность(быстрая деградация)
        public static void InsertionSort(int[] array)
        {
            for(int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int curUnsorted = array[partIndex];
                int i = 0;
                for(i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = curUnsorted;
            }
        }


        // Вспомогательный метод перестановки двух индексов
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
