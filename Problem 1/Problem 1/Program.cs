/*Problem Statement 1: “Given a string, check if the string is palindrome or not.” A string is 
said to be palindrome if the reverse of the string is the same as the string.
Example 1:
Input: Str = “ABCDCBA”
Output: Palindrome
Explanation: String final_termwhen reversed is the same as string.*/


using System;
namespace Problem_1
{
    internal class Program
    {
        static bool pallen(string s)
        {
            int left = 0;
            int right=s.Length -1 ;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if(pallen(s))
            {
                Console.WriteLine("is Palindrome");
            }
            else 
            {
                Console.WriteLine("not Palindorme");
            }
            Console.Read();
        }
    }
}
