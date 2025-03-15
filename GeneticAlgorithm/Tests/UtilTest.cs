using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneticAlgorithm.Tests
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void TestJoinArrays()
        {
            Util util = new Util();

            // Arrange
            bool[] arr1 = { true, false, true };
            bool[] arr2 = { false, true };

            // Act

            bool[] result = util.joinArrays(arr1, arr2);

            // Assert
            bool[] expected = { true, false, true, false, true };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSeperateArrays()
        {
            // Arrange
            Util util = new Util();
            bool[] arr = { true, false, true, false, true };
            int arr1Length = 3;
            int arr2Length = 2;

            // Act
            (bool[] arr1, bool[] arr2) result = util.seperateArrays(arr, arr1Length, arr2Length);

            // Assert
            bool[] expectedArr1 = { true, false, true };
            bool[] expectedArr2 = { false, true };
            CollectionAssert.AreEqual(expectedArr1, result.arr1);
            CollectionAssert.AreEqual(expectedArr2, result.arr2);
        }
    }
}