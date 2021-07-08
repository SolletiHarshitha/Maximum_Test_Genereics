using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumTestUsingGenerics;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        /*MaximumAmongThree max;

        public void SetUp()
        {
            max = new MaximumAmongThree();
        }*/
        /// <summary>
        /// TC 1.1 -Maximum Number at first value
        /// </summary>
        [TestMethod]
        public void TestMaxValue()
        {
            ///AAA Methodology
            //Arrange
            int firstValue = 30, secondValue = 10, thirdValue = 20;
            int expected = firstValue;
            //Act
            MaximumAmongThree max= new MaximumAmongThree(); ;
            int actual = max.FindMaxValueOfInt(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);
        }
         /// <summary>
         /// TC 1.2 -Maximum Number at second value
         /// </summary>
         [TestMethod]
         public void TestMethod2()
         {
             ///AAA Methodology
             //Arrange
             int firstValue = 10, secondValue = 30, thirdValue = 20;
             int expected = secondValue;
             //Act
             MaximumAmongThree max= new MaximumAmongThree(); ;
             int actual = max.FindMaxValueOfInt(firstValue, secondValue, thirdValue);
             //Assert
             Assert.AreEqual(expected, actual);
         }
         /// <summary>
         /// TC 1.3 -MAximum Number at third value
         /// </summary>
         [TestMethod]
         public void TestMethod3()
         {
             ///AAA Methodology
             //Arrange
             int firstValue = 10, secondValue = 20, thirdValue = 30;
             int expected = thirdValue;
             //Act
             MaximumAmongThree max= new MaximumAmongThree(); ;
             int actual = max.FindMaxValueOfInt(firstValue, secondValue, thirdValue);
             //Assert
             Assert.AreEqual(expected, actual);

         }



    }
}
