using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumTestUsingGenerics;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        /// <summary>
        /// TC 1.1 -Maximum Number at first value
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            ///AAA Methodology
            //Arrange
            float firstValue = 30.3f, secondValue = 10.3f, thirdValue = 20.3f;
            float expected = firstValue;
            //Act
            MaximumAmongThree max= new MaximumAmongThree(); ;
            float actual = max.FindMaxValueOfFloat(firstValue, secondValue, thirdValue);
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
             float firstValue = 10.3f, secondValue = 30.3f, thirdValue = 20.3f;
             float expected = secondValue;
             //Act
             MaximumAmongThree max= new MaximumAmongThree(); ;
             float actual = max.FindMaxValueOfFloat(firstValue, secondValue, thirdValue);
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
             float firstValue = 10.3f, secondValue = 20.3f, thirdValue = 30.3f;
             float expected = thirdValue;
             //Act
             MaximumAmongThree max= new MaximumAmongThree(); ;
             float actual = max.FindMaxValueOfFloat(firstValue, secondValue, thirdValue);
             //Assert
             Assert.AreEqual(expected, actual);

         }



    }
}
