using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Individual
    {
        public bool [] genes { get; set;}
        public bool[] x1Gens { get; set; }
        public bool[] x2Gens { get; set; }
        public double fitnessValue { get; set; }

        private static Random random = new Random();

        private static Fitness fitness = new Fitness();

        //Test 6 problem's parameters
        private const int dimensionCount = 2;
        private const double minValue = -10.0;
        private const double maxValue = 10.0;

        public Individual()
        {
            int x1Length = fitness.requiredBitsNumber().Item1; // Buralara precision degerleri gonderecek sekilde duzenliyecegiz...
            int x2Length = fitness.requiredBitsNumber().Item2;
            x1Gens = new bool[x1Length];
            x2Gens = new bool[x2Length];
            
            genes = new bool[x1Length + x2Length];

            for(int i = 0; i < x1Length+x2Length ; i++)
            {
                genes[i] = random.Next(2) == 1;
            }


            fitnessValue = fitness.calculateFitness(x1Gens, x2Gens);
        }

        public Individual(double[] genes)
        {
            genes = new double[dimensionCount];
            Array.Copy(genes, this.genes, dimensionCount);
            //fitness.calculateFitness(genes[0], genes[1]);
        }


        public Individual crossOver(Individual otherIndividual, double crossoverRate)
        {
            if(random.NextDouble() > crossoverRate)
            {
                //return new Individual(this.genes); // return a copy of this otherIndividual
            }

            double[] childGenes = new double[dimensionCount];

            for(int i = 0; i < dimensionCount; i++)
            {
                double alpha = random.NextDouble();
                //childGenes[i] = alpha * this.genes[i] * (1 - alpha) * otherIndividual.genes[i];

                childGenes[i] = Math.Max(minValue, Math.Min(maxValue, childGenes[i]));
            }

            return new Individual(childGenes);
        }
    }
}