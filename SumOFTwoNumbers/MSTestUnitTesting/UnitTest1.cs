
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOFTwoNumbers;

namespace MSTestUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private readonly SumOFTwoNumbers.Program program;

        public UnitTest1()
        {
            program = new SumOFTwoNumbers.Program();
        }
        [TestMethod]
        public void TestMethod1()  ///test method to make green 
        {
            int valueOne = 5;
            int valueTwo = 10;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethod2()   ///test method to make red
        {
            int valueOne = 5;
            int valueTwo = 5;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }
    }
}