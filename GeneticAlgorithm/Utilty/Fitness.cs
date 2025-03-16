using System;
using System.Runtime.CompilerServices;

namespace GeneticAlgorithm
{
    public class Fitness
    {
        private static double xMin = -10.0, xMax = 10.0;

        private static double yMin = -10.0, yMax = 10.0;

        private static BinaryEncoder binaryEncoder = new BinaryEncoder();

        double xLength = xMax - xMin;

        double yLength = yMax - yMin;
        private static double precisionValue { get; set; }

        public void setPrecision(double precision = 1000) {
            precisionValue = precision;
        }

        public double fitnessFunction(bool[] gen1,bool[] gen2)
        {
            //double x = binaryEncoder.decode(gen1);
            //double y = binaryEncoder.decode(gen2);
            double x = getActualXValue(gen1);
            double y = getActualYValue(gen2);

            double term1 = Math.Pow(x + 2 * y - 7, 2);
            double term2 = Math.Pow(2 * x + y - 5, 2);

            return term1 + term2;
        }

        public (int,int) requiredBitsNumber()
        {
            int xBits = (int)Math.Ceiling(Math.Log(xLength * precisionValue,2));
            int yBits = (int)Math.Ceiling(Math.Log(yLength * precisionValue,2));

            return (xBits,yBits);
        }

        public double getDecimalValue(bool[] gen1, bool[] gen2)
        {
            return binaryEncoder.BoolArrayToDouble(gen1) + binaryEncoder.BoolArrayToDouble(gen2);
        }

        public double getActualXValue(bool[] gen)
        {
            int xBits = requiredBitsNumber().Item1;
            return xMin + ((binaryEncoder.BoolArrayToDouble(gen)) / ((Math.Pow(2,xBits)) - 1)) * (xMax - (xMin));
        }
        public double getActualYValue(bool[] gen)
        {
            int yBits = requiredBitsNumber().Item2;
            return yMin + ((binaryEncoder.BoolArrayToDouble(gen)) / (Math.Pow(2, yBits) - 1)) * (yMax - (yMin));
        }
    }
}