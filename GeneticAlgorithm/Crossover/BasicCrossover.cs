using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Crossover
{
    public class BasicCrossover : ICrossover
    {
        private static Random random = new Random();

        public Individual crossover(Individual parent1, Individual parent2, double crossoverRate)
        {
            if (random.NextDouble() > crossoverRate)
            {
                return new Individual(parent1.genes); // Return copy of parent1 if crossover doesn't occur
            }

            bool[] childGenes = new bool[parent1.genes.Length];
            int crossoverPoint = random.Next(parent1.genes.Length);

            for (int i = 0; i < parent1.genes.Length; i++)
            {
                childGenes[i] = (i < crossoverPoint) ? parent1.genes[i] : parent2.genes[i];
            }

            return new Individual(childGenes);
        }
    }
}
