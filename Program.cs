/*
Find The Digit from Coding Challenges
by Silvio Duka

Last modified date: 2018-04-03

Create a program to find all the integer values between 0 and n, which contain the digit d. 
d is from the range 0 to 9. 

For Example: 
Input: n = 20, d = 5 
Output: 5, 15 

Input: n = 50, d = 2 
Output: 2, 12, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 32, 42. 

Bonus: You may extend the value of d to any integer value. 
For Example: 
Input: n = 300, d = 42 
Output: 42, 142, 242. 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50; // Insert end number of range (values between 0 and n)
            int d = 2; // Insert a digit (number) to search

            string result = String.Empty;

            for (int i = 0; i <= n; i++)
            {
                if (i.ToString().Contains(d.ToString()) == true) result += i.ToString() + ", ";
            }

            Console.WriteLine($"Input: n = {n}, d = {d}");
            Console.WriteLine($"Output: {result.TrimEnd().TrimEnd(',')}.");
        }
    }
}