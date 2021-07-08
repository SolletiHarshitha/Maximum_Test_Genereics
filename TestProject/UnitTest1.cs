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
            string firstValue = "Peach", secondValue = "Apple", thirdValue = "Banana";
            string expected = firstValue;
            //Act
            MaximumAmongThree max= new MaximumAmongThree(); ;
            string actual = max.FindMaxValueOfString(firstValue, secondValue, thirdValue);
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
            string firstValue = "Apple", secondValue = "Peach", thirdValue = "Banana";
            string expected = secondValue;
            //Act
            MaximumAmongThree max = new MaximumAmongThree(); ;
            string actual = max.FindMaxValueOfString(firstValue, secondValue, thirdValue);
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
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Peach";
            string expected = thirdValue;
            //Act
            MaximumAmongThree max = new MaximumAmongThree(); ;
            string actual = max.FindMaxValueOfString(firstValue, secondValue, thirdValue);
            //Assert
            Assert.AreEqual(expected, actual);

         }



    }
}
