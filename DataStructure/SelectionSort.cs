using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class SelectionSort
    {
        /*
         * Step1 :Find Min number from first 
         */
        public static int[] selectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[min_idx] > numbers[j])
                    {
                        min_idx = j;
                    }
                }
                int temp = numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }
        public void Run()
        {
            int[] number = new int[] { 40, 10, 60, 20, 5 };
            Console.WriteLine("selectionSort Un Sorted Array==>");

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            int[] numberSorted = new int[number.Length];

            numberSorted = selectionSort(number);
            Console.WriteLine("selectionSort Sorted Array==>");

            for (int i = 0; i < numberSorted.Length; i++)
            {
                Console.WriteLine(numberSorted[i]);
            }
        }
    }
}
