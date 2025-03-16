using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Tests
{
    [TestClass]
    public class BinaryEncoderTest
    {
        /*[TestMethod]
        public void TestEncode()
        {
            // Arrange
            BinaryEncoder encoder = new BinaryEncoder();
            double value = 5.0;

            // Act
            bool[] result = encoder.encode(value,15);

            // Assert
            Assert.AreEqual(16, result.Length);
            // Additional assertions can be added to verify the exact bit pattern if needed
        }

        [TestMethod]
        public void TestDecode()
        {
            // Arrange
            BinaryEncoder encoder = new BinaryEncoder();
            bool[] bits = encoder.encode(10.0,15);

            // Act
            double result = encoder.decode(bits);

            // Assert
            Assert.AreEqual(5.0, result, 0.01); // Allowing a small tolerance for floating-point comparison
        }

        [TestMethod]
        public void TestEncodeDecode()
        {
            // Arrange
            BinaryEncoder encoder = new BinaryEncoder();
            double originalValue = 5.0;

            // Act
            bool[] encodedBits = encoder.encode(originalValue,16);
            double decodedValue = encoder.decode(encodedBits);

            // Assert
            Assert.AreEqual(originalValue, decodedValue, 0.01); // Allowing a small tolerance for floating-point comparison
        }*/

        [TestMethod]
        public void Encode_ShouldConvertDecimalToBoolArray()
        {

            BinaryEncoder encoder = new BinaryEncoder();
            // Arrange
            double value = 50.0; // 0 ile 100 arasında ortada bir değer
            int bitLength = 15; // 8 bitlik bir çıktı istiyoruz

            // Act
            bool[] bits = encoder.DoubleToBoolArray(value, bitLength);

            // Assert
            Assert.IsNotNull(bits);
            Assert.AreEqual(bitLength, bits.Length);
        }

        [TestMethod]
        public void Decode_ShouldConvertBoolArrayToDecimal()
        {
            BinaryEncoder encoder = new BinaryEncoder();
            // Arrange
            bool[] bits = { false, false, true, true, false, false, true, false }; // 01100000 -> 96 (decimal)

            // Act
            double result = encoder.BoolArrayToDouble(bits);

            Assert.IsNotNull(result);
            Assert.AreEqual(50.0, result);
            // Assert
            //Assert.Range(result, 0, 100); // 0 ile 100 arasında olmalı
        }

        [TestMethod]
        public void EncodeAndDecode_ShouldReturnOriginalValue()
        {
            BinaryEncoder encoder = new BinaryEncoder();
            // Arrange
            double originalValue = 36.0;
            int bitLength = 10; // 10 bit kullanarak encode edeceğiz

            // Act
            bool[] bits = encoder.encode(originalValue, bitLength);
            double decodedValue = encoder.decode(bits);

            // Assert
            //Assert.InRange(decodedValue, originalValue - 1, originalValue + 1);
        }
    }
}
