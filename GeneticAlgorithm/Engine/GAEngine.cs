using GeneticAlgorithm.Crossover;
using GeneticAlgorithm.Mutation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int generationCount { get; private set; }

        private ICrossover crossover;

        private IMutation mutation;
        public bool isRouletteWheelSelection { get; private set; }

        public bool isTournamentSelection { get; private set; }

        public delegate void OnGenerationCompleteHandler(int generation, Individual individual);

        public event OnGenerationCompleteHandler onGenerationComplete;


        public GAEngine(int populationSize, double crossoverRate, double mutationRate, double eliteRate,int generationCount, bool isRouletteWheelSelection, bool isTournamentSelection,IMutation mutation, ICrossover crossover)
        {
            this.populationSize = populationSize;
            this.crossoverRate = crossoverRate;
            this.mutationRate = mutationRate;
            this.eliteRate = eliteRate;
            this.generationCount = generationCount;
            this.isRouletteWheelSelection = isRouletteWheelSelection;
            this.isTournamentSelection = isTournamentSelection;

            this.crossover = crossover;
            this.mutation = mutation;

            InitializePopulation();
        }

        public Individual run()
        {
            for(int generation = 1; generation <= generationCount; generation++)
            {
                generateNextGeneration();

                Individual bestIndividual = getFittest(population);

                onGenerationComplete?.Invoke(generation, bestIndividual);

                Task.Delay(25).Wait();
            }

            return getFittest(population);
        }

        private void InitializePopulation()
        {
            population = new List<Individual>();

            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new Individual());
            }

            //population.Sort();
            population = sortByFitnessValue(population);
        }

        private Individual tournamentSelection()
        {
            int tournamentSize = Math.Max(2, Math.Min(populationSize, populationSize / 10));

            tournamentSize = Math.Min(tournamentSize, population.Count);

            List<Individual> tournament = new List<Individual>(tournamentSize);

            while(tournament.Count < tournamentSize)
            {
                int randomIndex = random.Next(population.Count);
                if (!tournament.Contains(population[randomIndex]))
                {
                    tournament.Add(population[randomIndex]);
                }
            }

            return getFittest(tournament);
        }

        private Individual rouletteWheelSelection()
        {
            double totalFitness = population.Sum(ind => ind.fitnessValue);

            if (totalFitness == 0)
            {
                return population[random.Next(population.Count)];
            }

            List<double> relativeFitness = population.Select(ind => ind.fitnessValue / totalFitness).ToList();

            List<double> cumulativeProbability = new List<double>();
            double cumulativeSum = 0.0;

            foreach (double rf in relativeFitness)
            {
                cumulativeSum += rf;
                cumulativeProbability.Add(cumulativeSum);
            }

            double rand = random.NextDouble();

            // Rastgele noktanın hangi bireye ait olduğunu bul
            for (int i = 0; i < cumulativeProbability.Count; i++)
            {
                if (rand <= cumulativeProbability[i])
                {
                    return population[i];
                }
            }

            return getFittest(population);
        }

        public Individual getFittest(List<Individual> individuals)
        {
            return individuals.OrderBy(x => x.fitnessValue).FirstOrDefault();
        }

        public List<Individual> sortByFitnessValue(List<Individual> individuals)
        {
            return individuals.OrderBy(x => x.fitnessValue).ToList();
        }

        public void generateNextGeneration()
        {
            try
            {
                List<Individual> nextGeneration = new List<Individual>();
                int eliteCount = (int)(eliteRate * populationSize);
                eliteCount = Math.Min(eliteCount, population.Count);

                for (int i = 0; i < eliteCount; i++)
                {
                    nextGeneration.Add(population[i]);
                }
                while (nextGeneration.Count < populationSize - 1)
                {
                    Individual parent1 = isTournamentSelection ? tournamentSelection() : rouletteWheelSelection();
                    Individual parent2 = isTournamentSelection ? tournamentSelection() : rouletteWheelSelection();
                    Individual child = crossover.crossover(parent1, parent2, crossoverRate);

                    if (child == null)
                    {
                        throw new Exception("Crossover returned null child.");
                    }

                    child = mutation.mutate(child, mutationRate);

                    if (child == null)
                    {
                        throw new Exception("Mutation returned null child.");
                    }

                    nextGeneration.Add(child);
                }
                //nextGeneration.Sort();
                nextGeneration = sortByFitnessValue(nextGeneration);

                if (nextGeneration == null || nextGeneration.Count == 0)
                {
                    throw new Exception("Next generation is empty or null.");
                }

                population = nextGeneration;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in generateNextGeneration: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
