using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class GAEngine
    {
        public List<Individual> population;

        private static Random random = new Random();
        public int populationSize { get; private set; }
        public double crossoverRate { get; private set; }
        public double mutationRate { get; private set; }
        public double eliteRate { get; private set; }
        public bool isRealEncoding { get; private set; }
        public bool isTournamentSelection { get; private set; }



        public GAEngine(int populationSize, double crossoverRate, double mutationRate, double eliteRate, bool isRealEncoding, bool isTournamentSelection)
        {
            this.populationSize = populationSize;
            this.crossoverRate = crossoverRate;
            this.mutationRate = mutationRate;
            this.eliteRate = eliteRate;
            this.isRealEncoding = isRealEncoding;
            this.isTournamentSelection = isTournamentSelection;

            InitializePopulation();
        }


        private void InitializePopulation()
        {
            population = new List<Individual>();

            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new Individual());
            }

            population.Sort();
        }

        private Individual tournamentSelection()
        {
            int tournamentSize = Math.Max(2, populationSize / 10);

            List<Individual> tournament = new List<Individual>(tournamentSize);

            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = random.Next(populationSize);
                if (!tournament.Contains(population[randomIndex])) // Ayni bireyi birden fazla kez eklemiyoruz
                {
                    tournament.Add(population[randomIndex]);
                }
            }

            tournament.Sort();

            return tournament[0];
        }

    }
}
