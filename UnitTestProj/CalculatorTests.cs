using Moq;
using MyNewService;
using NUnit.Framework;

namespace UnitTestProj
{
     [TestFixture]
    public class CalculatorTests
    {
        private MockRepository mockRepository;

        
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

      public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void TestMethod1()
        {
            
            
            Calculator calculator = this.CreateCalculator();
            
            
        }

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }

        [Test]
        public void TestMethod2()
        {
            Calculator calculator = this.CreateCalculator();
            Assert.AreEqual(11, calculator.Sum(5, 6));

        }
    }
}
