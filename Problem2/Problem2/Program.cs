/*Problem Statement 2: Given a string, write a program to count the number of vowels,
consonants, and spaces in that string.
Example 1:
Input: string str =” Take u forward is Awesome”
Output: 
Vowels: 10
Consonants: 11
White spaces: 4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void CharCount(string str)
        {
            int vov = 0;
            int cons= 0;
            int space = 0;
            str=str.ToLower();
           // char []ch=str.ToCharArray();
            foreach(char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".Contains(ch))
                    {
                        vov = vov + 1;
                    }
                    else
                    {
                        cons = cons + 1;
                    }
                }
                else if (char.IsWhiteSpace(ch))
                {
                    space = space + 1;
                }
            }
            Console.WriteLine("Vovols in the str="+vov);
            Console.WriteLine("Consonenets in the str=" + cons);
            Console.WriteLine("White Spaces in the str=" + space);
        }
        static void Main(string[] args)
        {
            string str = "Take u forward is Awesome";
            CharCount(str);
        }
    }
}
