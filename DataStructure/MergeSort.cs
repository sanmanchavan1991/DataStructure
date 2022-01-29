using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class MergeSort
    {
        /*
         * Divide and Conquare
         * Step1 :Divide the array in half
         * Step2 :Divide until we have one char 
         * Step3 :Each Char is then compare with another char
         * Step4 :Compare until we have sorted array
        */
        public static int[] mergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int mid = numbers.Length / 2;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < mid)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);

                }
            }
            left = mergeSort(left.ToArray()).ToList();
            right = mergeSort(right.ToArray()).ToList();
            return merge(left, right);
        }
        public static int[] merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            while (left.Count > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }
            return result.ToArray();
        }
        public void Run()
        {
            int[] number = new int[] { 40, 10, 60, 20, 5 };
            Console.WriteLine("Un Sorted Array==>");

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            int[] numberSorted = new int[number.Length];

            numberSorted = mergeSort(number);
            Console.WriteLine("Sorted Array==>");

            for (int i = 0; i < numberSorted.Length; i++)
            {
                Console.WriteLine(numberSorted[i]);
            }
        }
    }
}
