using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Individual : IComparable<Individual>
    {
        public bool [] genes { get; set;}
        public bool[] x1Gens { get; set; }
        public bool[] x2Gens { get; set; }

        public double decimalValue { get; set; }
        public double fitnessValue { get; set; }

        private static Random random = new Random();

        private static Fitness fitness = new Fitness();

        private static Util util = new Util();

        public Individual()
        {
            int x1Length = fitness.requiredBitsNumber().Item1; // Buralara precision degerleri gonderecek sekilde duzenliyecegiz...
            int x2Length = fitness.requiredBitsNumber().Item2;            
            genes = new bool[x1Length + x2Length];

            for(int i = 0; i < x1Length+x2Length ; i++)
            {
                genes[i] = random.Next(2) == 1;
            }

            setX1AndX2Gens();
            fitnessValue = fitness.fitnessFunction(x1Gens, x2Gens);
        }

        public Individual(bool[] genes)
        {
            this.genes = new bool[genes.Length];
            Array.Copy(genes, this.genes, genes.Length);

            setX1AndX2Gens();
            fitness.fitnessFunction(x1Gens,x2Gens);
        }

        private void setX1AndX2Gens()
        {
            int x1Length = fitness.requiredBitsNumber().Item1;
            int x2Length = fitness.requiredBitsNumber().Item2;

            x1Gens = new bool[x1Length];
            x2Gens = new bool[x2Length];
            x1Gens = util.seperateArrays(genes, x1Length, x2Length).arr1;
            x2Gens = util.seperateArrays(genes, x1Length, x2Length).arr2;

            decimalValue = fitness.getDecimalValue(x1Gens, x2Gens);
        }

        public int CompareTo(Individual other)
        {
            return fitnessValue.CompareTo(other.fitnessValue);
        }
    }
}