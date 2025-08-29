using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    class Utility
    {
        #region Q1: Check if a number is prime.
        public static bool IsPrime(int number)
        {
            if (number == 2) return true;
            if (number <= 1 || number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

        /*********************************/
        #region Q2: Calculate the factorial of a number using recursion
        public static int Factorial(int number)
        {
            if(number ==0 || number == 1) return 1;
            return number * Factorial(number - 1);
        }
        #endregion

        /*********************************/
        #region Q3: Reverse the digits of an integer.
        public static int RevNumber(int number)
        {
            int rev = 0;
            while (number != 0)
            {
                rev = rev * 10 + number % 10;
                number = number / 10;
            }
            return rev;
        }
        #endregion

        /*********************************/
        #region Q4: Compute the sum of digits in a number.
        public static int SumOfDigit(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }
        #endregion

        /*********************************/
        #region Q5: Check if a number is a palindrome.
        public static bool CheckPalindrome(int number)
        {
            int rev = 0 , n = number;
            while (number != 0)
            {
                rev = rev * 10 + number % 10;
                number = number / 10;
            }
            return (rev == n) ? true : false ;
        }
        #endregion

        /*********************************/
        #region Q6: Reverse a string without using built-in functions.
        public static string ReverseString(string str)
        {
            string RevString = string.Empty;
            for(int i = str.Length - 1; i >= 0 ; i--)
            {
                RevString +=  str[i];
            }
            return RevString;
        }
        #endregion

        /*********************************/
        #region Q11: Implement a function to perform binary search on a sorted array.
        public static int BinarySearch(int[] arr , int number)
        {
            int left = 0, right = arr.Length - 1, mid = 0;
            while(left <= right)
            {
                mid = left + (right - left) / 2;
                if (arr[mid] == number) return mid;
                else if (arr[mid] < number) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        #endregion





    }
}
