using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class BinaryEncoder
    {
        private double minValue = -10;
        private double maxValue = 10;

        public BinaryEncoder()
        {

        }

        public bool[] encode(double value, int arrayLength)//50 15
        {
            double normalizedValue = (value - minValue) / (maxValue - minValue);// 60 / 20 = 3
            long maxVal = (1L << arrayLength) - 1; // 2^15 - 1 = 32767
            long intVal = (long)(normalizedValue * maxVal);  // 3 * 32767 = 98301

            bool[] bits = new bool[arrayLength]; // 15

            // Ters sırayla atıyoruz, MSB en başa gelmeli
            for (int i = 0; i < arrayLength; i++)
            {
                bits[arrayLength - 1 - i] = ((intVal >> i) & 1) == 1;
            }

            return bits;
        }

        public double decode(bool[] bits)
        {
            long intVal = 0;

            // Ters sırayla okumalıyız
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[bits.Length - 1 - i])
                {
                    intVal |= (1L << i);
                }
            }

            long maxVal = (1L << bits.Length) - 1;
            double normalizedValue = (double)intVal / maxVal;

            return minValue + normalizedValue * (maxValue - minValue);
        }

        public bool[] DoubleToBoolArray(double number, int length)
        {
            bool[] result = new bool[length];

            // Sayının pozitif olduğundan emin ol
            if (number < 0)
            {
                throw new ArgumentException("Sadece pozitif sayılar desteklenmektedir.");
            }

            // Tam sayı kısmını al
            long integerPart = (long)number;

            // Sayıyı ikili sisteme dönüştür
            for (int i = 0; i < length && integerPart > 0; i++)
            {
                result[length - i - 1] = (integerPart % 2) == 1;
                integerPart /= 2;
            }
            result = reverseArray(result);

            return result;
        }

        // Bool dizisini double sayıya dönüştürür
        public double BoolArrayToDouble(bool[] boolArray)
        {
            if (boolArray == null || boolArray.Length == 0)
                return 0;

            double result = 0;
            boolArray = reverseArray(boolArray);

            // Tam sayı kısmını hesapla
            for (int i = 0; i < boolArray.Length; i++)
            {
                if (boolArray[i])
                {
                    // i. bit 1 ise, 2^(length-i-1) değerini ekle
                    if (i < 52) // Double precision için üst sınır
                    {
                        result += Math.Pow(2, boolArray.Length - i - 1);
                    }
                }
            }

            return result;
        }


        private bool[] reverseArray(bool[] array)
        {
            bool[] reversedArray = new bool[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }
            return reversedArray;
        }
    }
}
