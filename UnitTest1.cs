using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testcalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Add_Should_Return_Sum_Of_Two_numbers() 
        {
            //Arrange
            Calculator calculator = new Calculator();
            int a = 2;
            int b = 3;
            int expected = 5;

            //Act
            int result = calculator.add(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
