using GeneticAlgorithm.Crossover;
using GeneticAlgorithm.Exceptions;
using GeneticAlgorithm.Forms;
using GeneticAlgorithm.Mutation;
using GeneticAlgorithm.Validator;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class MainForm : Form
    {
        private InputValidator inputValidator;

        private Fitness fitness;

        private bool isTournamentSelection = true;

        private bool isRouletteSelection;

        private IMutation mutation = new RandomMutation();

        private ICrossover crossover = new BasicCrossover();

        public MainForm()
        {
            InitializeComponent();
            inputValidator = new InputValidator(this);
            fitness = new Fitness();
            loadFitnessFunctionImage();
        }

        private void loadFitnessFunctionImage()
        {
            try
            {
                string test6Formula = Path.Combine(Application.StartupPath, "Test6Formula.png");
                string test6SearchDomain = Path.Combine(Application.StartupPath, "Test6SearchDomainv2.png");

                if (File.Exists(test6Formula))
                {
                    pictureBox_Test6Formula.Image = Image.FromFile(test6Formula);
                }
                else
                {
                    throw new Exceptions.FileNotFoundException("Test6 Formula picture not found!");
                }

                if (File.Exists(test6SearchDomain))
                {
                    pictureBox_Test6SearchDomain.Image = Image.FromFile(test6SearchDomain);
                }
                else
                {
                    throw new Exceptions.FileNotFoundException("Test6 Search Domain picture not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            try
            {
                var inputs = inputValidator.validateAndGetInputs();
                fitness.setPrecision(inputs.precision);

                GAEngine genericAlgorithmEngine = new GAEngine(
                    inputs.populationSize,
                    inputs.crossoverRate,
                    inputs.mutationRate,
                    inputs.eliteRate,
                    inputs.generationCount,
                    isRouletteSelection,
                    isTournamentSelection,
                    mutation,
                    crossover
                    );

                GraphicForm graphicForm = new GraphicForm(genericAlgorithmEngine);

                graphicForm.ShowDialog();
            }
            catch (IncorretInputException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void checkBox_TournamentSelection_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_TournamentSelection.Checked)
            {
                checkBox_RouletteSelection.Checked = false;
                isTournamentSelection = true;
                isRouletteSelection = false;
            }
        }

        private void checkBox_RouletteSelection_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_RouletteSelection.Checked)
            {
                checkBox_TournamentSelection.Checked = false;
                isTournamentSelection = false;
                isRouletteSelection = true;
            }
        }
    }
}
