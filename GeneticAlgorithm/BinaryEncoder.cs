using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class BinaryEncoder
    {
        private int bitsPerVariable;
        private double minValue = -10;
        private double maxValue = 10;

        public BinaryEncoder(int bitsPerVariable = 16)
        {
            this.bitsPerVariable = bitsPerVariable;
        }

        public bool[] encode(double value) //26
        {
            double normalizedValue = (value - minValue) / (maxValue - minValue); // 36 / 20 = 1.8

            long maxVal = (1L << bitsPerVariable) - 1;


            long intVal = (long)(normalizedValue * maxVal); // 1.8 * 65535 = 117763

            bool[] bits = new bool[bitsPerVariable];

            for (int i = 0; i < bitsPerVariable; i++)
            {
                bits[i] = ((intVal >> i) & 1) == 1;
            }

            return bits;
        }


        public double decode(bool[] bits)
        {
            long intVal = 0;

            for(int i = 0; i < bits.Length; i++)
            {
                if (bits[i])
                {
                    intVal |= (1L << i);
                }
            }

            long maxVal = (1L << bitsPerVariable) - 1;

            double normalizedValue = (double)intVal / maxVal;

            return minValue + normalizedValue * (maxValue);
        }
    }
}
