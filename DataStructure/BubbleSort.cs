using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BubbleSort
    {
        /*
         * Step1 Each loop move largest element at last
         * Step2 Do it until sorted
         */
        public static int[] bubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++) //We can also write Like This
                                                             //for (int j = 0; j < numbers.Length-i-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
        public void Run()
        {
            int[] number = new int[] { 40, 10, 60, 20, 5 };
            Console.WriteLine("Bubble Un Sorted Array==>");

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            int[] numberSorted = new int[number.Length];

            numberSorted = bubbleSort(number);
            Console.WriteLine("Bubble Sorted Array==>");

            for (int i = 0; i < numberSorted.Length; i++)
            {
                Console.WriteLine(numberSorted[i]);
            }
        }
    }
}
