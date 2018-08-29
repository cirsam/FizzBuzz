using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharptInterviewquestions
{
    public class FizzBuzz
    {
        public string FizzBuzzMethod(int number)
        {
            string result = "";

            if (number%5==0 && number%3==0)
            {
                result = "FizzBuzz";
            }
            else if (number%3==0)
            {
                result = "Fizz";
            }
            else if (number%5==0)
            {
                result = "Buzz";
            }
            
            return result;
        }
    }
}
