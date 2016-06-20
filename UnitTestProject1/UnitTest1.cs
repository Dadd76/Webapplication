using System;
using Fizz;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void TestMethod1(int i)
        {
            FizzBuzz test = new FizzBuzz();

            string message = string.Empty;

            //int messageValue;

            message = test.GetMessage(i);


            //messageValue = int.TryParse(message);

            Assert.AreEqual(message, i.ToString());

        }



    }
}
