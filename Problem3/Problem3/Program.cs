/*Problem Statement 3: Given a String, write a program to remove vowels from a given 
String.
Example 1:
Input: Str = “take u forward”
Output: tk frwrd
Explanation: All vowels are removed from the given String.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void VovRem(string str)
        {
            string remove = "aeiouAEIOU";
            string final = "";
            foreach(char ch in str)
            {
                if (!remove.Contains(ch.ToString()){
                    final += ch;
                }
            }
            return final;

        }
        static void Main(string[] args)
        {
            string str = "take u forward";
            string outs=VovRem(str);
            Console.WriteLine(outs);
        }
    }
}
