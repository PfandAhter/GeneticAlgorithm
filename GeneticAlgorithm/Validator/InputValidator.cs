using GeneticAlgorithm.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm.Validator
{
    public class InputValidator
    {
        private static MainForm gameForm;

        public InputValidator(MainForm mainForm)
        {
            gameForm = mainForm;
        }

        public bool validateInputs()
        {
            try
            {
                if(!int.TryParse(gameForm.Controls["numericUpDown_PopulationSize"].Text,out int populationSize))
                {
                    throw new IncorretInputException("Population size must be a number");
                }
                
                if(populationSize < 1)
                {
                    throw new IncorretInputException("Population size must be greater than 0");
                }

                if (!double.TryParse(gameForm.Controls["numericUpDown_CrossoverRate"].Text,out double crossoverRate))
                {
                    throw new IncorretInputException("Crossover rate must be a number");
                }

                if(crossoverRate < 0 || crossoverRate > 1)
                {
                    throw new IncorretInputException("Crossover rate must be between 0 and 1");
                }

                if(!double.TryParse(gameForm.Controls["numericUpDown_MutationRate"].Text, out double mutationRate))
                {
                    throw new IncorretInputException("Mutation rate must be a number");
                }

                if (mutationRate < 0 || mutationRate > 1)
                {
                    throw new IncorretInputException("Mutation rate must be between 0 and 1");
                }

                if (!double.TryParse(gameForm.Controls["numericUpDown_EliteRate"].Text, out double eliteRate))
                {
                    throw new IncorretInputException("Elite rate must be a number");
                }

                if (eliteRate < 0 || eliteRate > 1)
                {
                    throw new IncorretInputException("Elite rate must be between 0 and 1");
                }

                if (!int.TryParse(gameForm.Controls["numericUpDown_GenerationCount"].Text, out int generationCount))
                {
                    throw new IncorretInputException("Generation count must be a number");
                }

                if (generationCount < 1)
                {
                    throw new IncorretInputException("Generation count must be greater than 0");
                }

                if(!int.TryParse(gameForm.Controls["numericUpDown_PrecisionValue"].Text, out int precision))
                {
                    throw new IncorretInputException("Precision must be a number");
                }

                if (precision < 1)
                {
                    throw new IncorretInputException("Precision must be greater than 0");
                }

                return true;
            }
            catch (IncorretInputException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public (int populationSize, double crossoverRate, double mutationRate, double eliteRate, int generationCount, int precision) validateAndGetInputs()
        {
            if (validateInputs())
            {
                int populationSize = int.Parse(gameForm.Controls["numericUpDown_PopulationSize"].Text);
                double crossoverRate = double.Parse(gameForm.Controls["numericUpDown_CrossoverRate"].Text);
                double mutationRate = double.Parse(gameForm.Controls["numericUpDown_MutationRate"].Text);
                double eliteRate = double.Parse(gameForm.Controls["numericUpDown_EliteRate"].Text);
                int generationCount = int.Parse(gameForm.Controls["numericUpDown_GenerationCount"].Text);
                int precision = int.Parse(gameForm.Controls["numericUpDown_PrecisionValue"].Text);
                return (populationSize, crossoverRate, mutationRate, eliteRate, generationCount, precision);
            }
            else
            {
                throw new Exception("Invalid input");
            }
        }
    }
}
