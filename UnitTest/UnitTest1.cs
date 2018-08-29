using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharptInterviewquestions;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBussInt2()
        {
            FizzBuzz fizzbuss = new FizzBuzz();
            int number = 2;
            string result = fizzbuss.FizzBuzzMethod(number);

            Assert.AreEqual("",result);  
        }

        [TestMethod]
        public void FizzBussInt5()
        {
            FizzBuzz fizzbuss = new FizzBuzz();
            int number = 5;
            fizzbuss.FizzBuzzMethod(number);

            string result = fizzbuss.FizzBuzzMethod(number);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBussInt9()
        {
            FizzBuzz fizzbuss = new FizzBuzz();
            int number = 9;
            fizzbuss.FizzBuzzMethod(number);

            string result = fizzbuss.FizzBuzzMethod(number);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBussInt15()
        {
            FizzBuzz fizzbuss = new FizzBuzz();
            int number = 15;
            fizzbuss.FizzBuzzMethod(number);

            string result = fizzbuss.FizzBuzzMethod(number);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBussInt100()
        {
            FizzBuzz fizzbuss = new FizzBuzz();
            int number = 100;
            fizzbuss.FizzBuzzMethod(number);

            string result = fizzbuss.FizzBuzzMethod(number);

            Assert.AreEqual("Buzz", result);
        }
    }
}
