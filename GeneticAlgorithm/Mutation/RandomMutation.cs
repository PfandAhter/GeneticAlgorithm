using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm.Mutation
{
    public class RandomMutation : IMutation
    {
        private static Random random = new Random();

        private static Fitness fitness = new Fitness();

        public Individual mutate(Individual individual, double mutationRate)
        {
            try
            {
                if (individual == null || individual.genes == null)
                {
                    throw new ArgumentNullException("individual or individual.genes is null");
                }

                for (int i = 0; i < individual.genes.Length; i++)
                {
                    if (random.NextDouble() < mutationRate)
                    {
                        individual.genes[i] = !individual.genes[i];
                    }
                }

                if (individual.x1Gens == null || individual.x2Gens == null)
                {
                    throw new ArgumentNullException("individual.x1Gens or individual.x2Gens is null");
                }

                individual.fitnessValue = fitness.fitnessFunction(individual.x1Gens, individual.x2Gens);

                return individual;
            }
            catch (Exception ex)
            {
                // Log the exception details
                Console.WriteLine($"Exception in mutate method: {ex.Message}");
                Console.WriteLine(ex.StackTrace);

                // Show the error message
                MessageBox.Show(ex.Message, "Mutation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*try
        {
            for (int i = 0; i < individual.genes.Length; i++)
            {
                if (random.NextDouble() < mutationRate)
                {
                    individual.genes[i] = !individual.genes[i];
                }
            }
            individual.fitnessValue = fitness.fitnessFunction(individual.x1Gens, individual.x2Gens);

            return individual;
        }catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Mutation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }*/
    
    }
}