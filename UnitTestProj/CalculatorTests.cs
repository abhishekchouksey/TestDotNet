using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyNewService;

namespace UnitTestProj
{
    [TestClass]
    public class CalculatorTests
    {
        private MockRepository mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            
            Calculator calculator = this.CreateCalculator();
            
            
        }

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator calculator = this.CreateCalculator();
            Assert.AreEqual(11, calculator.Sum(5, 6));

        }
    }
}
