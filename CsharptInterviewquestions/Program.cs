using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharptInterviewquestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THE FIZZBUSS INTERVIEW QUESTION");
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine("2 should give you empty string ={0} ", fizzBuzz.FizzBuzzMethod(2));
            Console.WriteLine("3 should give you Fizz ={0} ", fizzBuzz.FizzBuzzMethod(3));
            Console.WriteLine("5 should give you Buzz ={0} ", fizzBuzz.FizzBuzzMethod(5));
            Console.WriteLine("15 should give you FizzBuzz ={0} ", fizzBuzz.FizzBuzzMethod(15));
            Console.ReadKey();
        }
    }
}
