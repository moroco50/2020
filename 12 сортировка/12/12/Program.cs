using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static int SwapCounter = 0;
        static int DifferenceCounter = 0;
        static void Main(string[] args)
        {

            CheckShakerSort();
            CheckMergeSort();
            Console.ReadKey();
        }
        static void WriteArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static void CheckMergeSort()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Сортировка слиянием");
            int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            MergeSort(ref mas1);
            Console.WriteLine($"Сортированный по возростанию массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;

            int[] mas2 = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            MergeSort(ref mas2);
            Console.WriteLine($"Сортированный по убыванию массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;

            int[] mas3 = { 1, 14, 20, 2, 15, 19, 3, 5, 12, 6, 17, 4, 18, 13, 7, 10, 8, 9, 11, 16 };
            MergeSort(ref mas3);
            Console.WriteLine($"Не сортированный массив массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;
        }
        static void CheckShakerSort()
        {
            Console.WriteLine("Сортировка методом перемешивания или Шейкера.");
            int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            ShakerSort(ref mas1);
            Console.WriteLine($"Сортированный по возростанию массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;

            int[] mas2 = { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ShakerSort(ref mas2);
            Console.WriteLine($"Сортированный по убыванию массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;

            int[] mas3 = { 1, 14, 20, 2, 15, 19, 3, 5, 12, 6, 17, 4, 18, 13, 7, 10, 8, 9, 11, 16 };
            ShakerSort(ref mas3);
            Console.WriteLine($"Не сортированный массив массив.\nКол-во сравнений - {DifferenceCounter}, кол-во перемещений - {SwapCounter}");
            WriteArray(mas1);
            DifferenceCounter = 0;
            SwapCounter = 0;
        }
        static void MergeSort(ref int[] array)
        {
            MergeSort(ref array, 0, array.Length - 1);
        }
        static void MergeSort(ref int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(ref array, lowIndex, middleIndex);
                MergeSort(ref array, middleIndex + 1, highIndex);
                Merge(ref array, lowIndex, middleIndex, highIndex);
            }
        }
        static void Merge(ref int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                DifferenceCounter++;
                SwapCounter++;
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                SwapCounter++;
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                SwapCounter++;
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                SwapCounter++;
                array[lowIndex + i] = tempArray[i];
            }
        }
        static void ShakerSort(ref int[] mas)
        {
            int left = 0,
            right = mas.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    DifferenceCounter++;
                    if (mas[i] > mas[i + 1]) Swap(ref mas, i, i + 1);
                }
                right--;

                for (int i = right; i >

                left; i--)
                {
                    DifferenceCounter++;
                    if (mas[i - 1] > mas[i]) Swap(ref mas, i - 1, i);
                }
                left++;
            }
        }
        static void Swap(ref int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
            SwapCounter++;
        }

    }
}