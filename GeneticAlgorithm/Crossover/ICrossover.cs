using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Crossover
{
    public interface ICrossover
    {
        Individual crossover(Individual parent1, Individual parent2, double crossoverRate);
    }
}
