/*Problem Statement 4: Given a string, write a program to remove all the whitespaces from 
the string.
Example 1:
Input: str = “Take you forward” 
Output: Takeyouforward
Explanation: After removing all the whitespaces Takeyouforward is the result
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    internal class Program
    {
        static string RemWhiteSpace(string inp) 
        { 
            string output= "";
            foreach(char ch in inp)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    output += ch;
                }   
            }
            return output;
        }

        static void Main(string[] args)
        {
            string inp = "Take you forward";
            string outs = RemWhiteSpace(inp);
            Console.WriteLine(outs);
        }
    }
}
