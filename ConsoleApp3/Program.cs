using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp3
{
    class Program
    {
       public delegate double getDataofFunc(int[] arr);
        static void SumOfDigits(int num)
        {
            
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
      public static double FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine("second highest value is {0}",max2);
            return max2;
        }
        static ArrayList get2NonRepeatingNos(int[] nums, int n)
        {

            Array.Sort(nums);

            ArrayList ans = new ArrayList();
            for (int i = 0; i < n - 1; i = i + 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    ans.Add(nums[i]);
                    i = i - 1;
                }
            }

            if (ans.Count == 1)
                ans.Add(nums[n - 1]);

            return ans;
        }
        public static void print2SingleNumbers(int[] nums)
        {

            // Create a Map Set to store the numbers
            HashSet<int> set = new HashSet<int>();

            int n = nums.Length;

            /*Iterate through the array and check if each
                element is present or not in the set. If the
              element is present, remove it from the array
              otherwise add it to the set*/

            for (int i = 0; i < n; i++)
            {
                if (set.Contains(nums[i]))
                    set.Remove(nums[i]);
                else
                    set.Add(nums[i]);
            }

            /*Since there will only be 2 non-repeating elements
                we can directly print them*/
            Console.Write("The 2 non repeating numbers are : ");
            foreach (var val in set) Console.Write(val + " ");
        }
        public static int findDupliacte(int[] arr)
        {
            int n = arr.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result ^ arr[i];
            }
            Console.WriteLine(result);


            return result;
            
        }
        static void UniqueNumbers2(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                // Xor  all the elements of the array
                // all the elements occurring twice will
                // cancel out each other remaining
                // two unique numbers will be xored
                sum = (sum ^ arr[i]);
            }

            // Bitwise & the sum with it's 2's Complement
            // Bitwise & will give us the sum containing
            // only the rightmost set bit
            sum = (sum & -sum);

            // sum1 and sum2 will contains 2 unique
            // elements  initialized with 0 box
            // number xored with 0 is number itself
            int sum1 = 0;
            int sum2 = 0;

            // Traversing the array again
            for (int i = 0; i < arr.Length; i++)
            {

                // Bitwise & the arr[i] with the sum
                // Two possibilities either result == 0
                // or result > 0
                if ((arr[i] & sum) > 0)
                {

                    // If result > 0 then arr[i] xored
                    // with the sum1
                    sum1 = (sum1 ^ arr[i]);
                }
                else
                {

                    // If result == 0 then arr[i]
                    // xored with sum2
                    sum2 = (sum2 ^ arr[i]);
                }
            }

            // Print the two unique numbers
            Console.WriteLine("The non-repeating "
                              + "elements are " + sum1 + " and "
                              + sum2);
        }
        static void Main(string[] args)
        {
           // getDataofFunc dpointer = FindSecondLargeInArray;


           // int[] values = { 1, 4, 3, 6, 7, 8 };
           // double val = dpointer.Invoke(values);
           // //int[] arr = { 2, 3, 7, 9, 11, 2, 3, 11 };
           // //int n = arr.Length;
           // //UniqueNumbers2(arr,n);
           // //int n = arr.Length;
           // //ArrayList ans = get2NonRepeatingNos(arr, n);
           // //Console.Write("The non-repeating elements are ");
           // //Console.WriteLine(ans[0] + " and " + ans[1]);
           // //int[] nums = new int[] { 2, 3, 7, 9, 11, 2, 3, 11 };
           // //print2SingleNumbers(nums);
           // //int[] array = { 2, 8, 4, 5, 6 };
           // //FindSecondLargeInArray(array);
           // //SumOfDigits(503);
           // Console.WriteLine("Hello World!");

           // BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,
           //     Expression.Constant(10),
           //     Expression.Constant(20));

           // BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
           //    Expression.Constant(5),
           //    Expression.Constant(3));

           // BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract,
           //   b1,
           //    b2);
           //int result = Expression.Lambda<Func<int>>(b3).Compile()();

           // List<string> countrylist = new List<string>();
           // countrylist.Add("INDIA");
           // countrylist.Add("CHINA");
           // countrylist.Add("PAKISTAN");
           // countrylist.Add("USA");
           // countrylist.Add("UK");
           // countrylist.Add("JAPAN");

           // var lst = from l in countrylist select l.ToString();
                     
           // foreach(string s in lst)
           // {
           //     Console.WriteLine(s);
           // }
      

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort the arr from last to first
            // Normal compare is m-n
            Array.Sort<int>(arr, delegate (int m, int n)
            { return n - m; });

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

        }
    }
}
