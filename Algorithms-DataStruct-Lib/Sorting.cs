using System;
using System.Collections.Generic;
using System.Globalization;
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
        // Эффективна на уже почти отсортированном входном массиве
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

        // Основан на сортировке вставками 
        // Идея алгоритма = предварительно отсортировать 
        // Когда gap = 1, процесс переключается на сортировку вставками
        // Использует малое кол-во памяти("In-place" алгоритм)
        // Нестабильный
        // O(N^(3/2))
        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length)
                gap = 3 * gap + 1;

            while(gap >=1)
            {
                for(int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j]< array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }

                }
                gap /= 3;
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
