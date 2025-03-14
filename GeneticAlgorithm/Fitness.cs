using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GeneticAlgorithm
{
    public class Fitness
    {
        private static double xMin = -10.0, xMax = 10.0;

        private static double yMin = -10.0, yMax = 10.0;

        private static BinaryEncoder binaryEncoder = new BinaryEncoder();

        double xLength = xMax - xMin;

        double yLength = yMax - yMin;

        public double calculateFitness(bool[] gen1,bool[] gen2)
        {
            double x = binaryEncoder.decode(gen1);
            double y = binaryEncoder.decode(gen2);

            double term1 = Math.Pow(x + 2 * y - 7, 2);
            double term2 = Math.Pow(2 * x + y - 5, 2);

            return term1 + term2;
        }

        public (int,int) requiredBitsNumber(double precision = 1000)
        {
            int xBits = (int)Math.Ceiling(Math.Log(xLength * precision));
            int yBits = (int)Math.Ceiling(Math.Log(yLength * precision));

            return (xBits,yBits);
        }
    }
}
