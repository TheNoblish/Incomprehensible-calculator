using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incomprehensible_calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0; int c = 0; int b; bool h = false; bool o = false;while (!h){Console.WriteLine("Enter first number"); try{q = Convert.ToInt32(Console.ReadLine());h = true;Console.WriteLine("First number = " + q);}catch{Console.WriteLine("Not a number");}}while (!o){Console.WriteLine("Enter second number");try{c = Convert.ToInt32(Console.ReadLine());o = true;Console.WriteLine("Second number = " + c);}catch{Console.WriteLine("Not a number");}}if (q == c){Console.WriteLine("Tripling sum of " + q + " and " + c);b = q + c + q + c + q + c;Console.WriteLine("Result is " + b);}else{Console.WriteLine("Finding sum of " + q + " and " + c);b = q + c;Console.WriteLine("Result is " + b);}Console.WriteLine("Now go away");Console.ReadLine();
        }
    }
}
