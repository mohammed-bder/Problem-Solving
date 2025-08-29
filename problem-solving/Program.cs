using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace problem_solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Check if a number is prime.

            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());

            //bool result = Utility.IsPrime(number);
            //Console.WriteLine(result ? $"{number} is Prime" : $"{number} is Not Prime");

            #endregion

            /*********************************************************/

            #region Q2: Calculate the factorial of a number using recursion

            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //    Console.WriteLine("Factorial is not defined for negative numbers.");

            //int result = Utility.Factorial(number);
            //Console.WriteLine($"Factorial {number} is = {result}");

            #endregion

            /*********************************************************/

            #region Q3: Reverse the digits of an integer.
            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());

            //int result = Utility.RevNumber(number);
            //Console.WriteLine($"Rev Number : {result}");

            #endregion

            /*********************************************************/

            #region Q4: Compute the sum of digits in a number.
            // 1234
            // sum = 1 + 2 + 3 + 4
            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());

            //int result = Utility.SumOfDigit(number);
            //Console.WriteLine($"the sum of digits : {result}");

            #endregion

            /*********************************************************/

            #region Q5: Check if a number is a palindrome.
            // palindrome is true if the number is same when read forwards or backwards
            // 12321 ~ 12321
            //Console.WriteLine("Enter a Number");
            //int number = int.Parse(Console.ReadLine());

            //bool result = Utility.CheckPalindrome(number);
            //Console.WriteLine(result ? "the number is a palindrome. " : "the number is Not palindrome.");

            #endregion

            /*********************************************************/

            #region Q6: Reverse a string without using built-in functions.
            // Hello ==>> olleH
            //Console.WriteLine("Enter the string");
            //string str = Console.ReadLine();

            //string revString =string.Empty;
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    revString += str[i];
            //}
            //Console.WriteLine($"Rev String : {revString}");

            #endregion

            /*********************************************************/

            #region Q7: Check if a string is a palindrome.
            //Console.WriteLine("Enter the string");
            //string str = Console.ReadLine();

            //string revString = string.Empty;
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    revString += str[i];
            //}

            //Console.WriteLine((revString == str) ? "the string is a palindrome. " : "the string is Not palindrome.");

            #endregion

            /*********************************************************/

            #region Q8: Find the maximum and minimum elements in an array.
            //int[] arr = { 1, 5, 10, 9, 12, 15, 14, 6, 17, 18 };
            //int max = arr[0], min = arr[0];
            //for(int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Min: {min} , Max: {max}");
            #endregion

            /*********************************************************/
            #region Q9: Remove duplicates from an array.
            //int[] arr = { 1, 5, 10, 9, 12, 15, 14, 6, 17, 18 , 12 , 1 , 6 };
            //List<int > unique = new List<int>();
            //foreach(int Number in arr)
            //{
            //    if(!unique.Contains(Number))
            //        unique.Add(Number);
            //}
            //foreach(int number in unique)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            /*********************************************************/
            #region Q10: Merge two sorted arrays into one sorted array.
            // int[] arr1 = { 1, 3, 5, 8, 10};
            // int[] arr2 = { 2, 4, 6, 7, 10, 15 };
            // int[] merged = new int[arr1.Length + arr2.Length];

            //int i = 0 , j = 0 , k = 0;

            // while (i < arr1.Length && j < arr2.Length)
            // {
            //     if (arr1[i] < arr2[j])
            //     {
            //         merged[k++] = arr1[i++];
            //     }
            //     else
            //     {
            //         merged[k++] = arr2[j++];
            //     }
            // }
            // while (i < arr1.Length)
            // {
            //     merged[k++] = arr1[i++];
            // }
            // while (j < arr2.Length)
            // {
            //     merged[k++] = arr2[j++];
            // }
            // foreach (int number in merged)
            // {
            //     Console.Write(number + " ");
            // }

            #endregion

            /*********************************************************/
            #region Q11: Implement a function to perform binary search on a sorted array.
            //Console.WriteLine("Enter the number to search");
            //int.TryParse(Console.ReadLine() , out int number);

            //int[] arr = { 1, 3, 5, 8, 10, 12, 15, 20, 25, 30 };
            //int result = Utility.BinarySearch(arr, number); 
            //Console.WriteLine(result == -1 ? "Not Found" : $"Found at index {result}");

            #endregion

            /*********************************************************/
            #region Q12: Determine the common elements between two arrays.
            int[] arr1 = { 1, 3, 5, 8, 10 };
            int[] arr2 = { 2, 5, 6, 7, 10, 1};
            List<int> common = new List<int>();
            foreach(int number in arr1)
            {
                if (arr2.Contains(number) && !common.Contains(number))
                    common.Add(number);
            }
            foreach(int number in common)
            {
                Console.Write(number + " ");
            }
            #endregion

        }
    }
}
