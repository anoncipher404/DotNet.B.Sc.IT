/*Problem Statement 5 : Write a program to remove all characters from a string except 
alphabets in a given string
Example 1:
Input: string str = "take12% *&u ^$#forward"
Output: takeuforward
Explanation:
Characters 1,2,%,*,&,^,$,# along with whitespaces are 
removed but the order of remaining alphabets is preserved.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Program
    {
        static string RemNoAlpha(string inp)
        {
            string stout = "";
            foreach(char ch in inp)
            {
                if (char.IsLetter(ch))
                {
                    stout += ch;
                }
            }
            return stout;
        }
        static void Main(string[] args)
        {
            string str = "take12% *&u ^$#forward";
            string outs = RemNoAlpha(str);
            Console.WriteLine(outs);
        }
    }
}
