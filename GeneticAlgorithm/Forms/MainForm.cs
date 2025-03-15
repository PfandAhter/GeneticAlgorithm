using GeneticAlgorithm.Crossover;
using GeneticAlgorithm.Exceptions;
using GeneticAlgorithm.Forms;
using GeneticAlgorithm.Mutation;
using GeneticAlgorithm.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm
{
    public partial class MainForm : Form
    {
        private String thema = "#082c30";

        private InputValidator inputValidator;

        private Fitness fitness;

        private List<double> bestFitnessHistory;

        private IMutation mutation = new RandomMutation();

        private ICrossover crossover = new BasicCrossover();

        public MainForm()
        {
            InitializeComponent();
            inputValidator = new InputValidator(this);
            //this.BackColor = ColorTranslator.FromHtml(thema);
            //SetupChart();
            //chart_generation.BackColor = ColorTranslator.FromHtml(thema);
            bestFitnessHistory = new List<double>();
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

                /*chart_generation.Series["BestFitness"].Points.Clear();
                bestFitnessHistory.Clear();*/
                

                GAEngine genericAlgorithmEngine = new GAEngine(
                    inputs.populationSize,
                    inputs.crossoverRate,
                    inputs.mutationRate,
                    inputs.eliteRate,
                    inputs.generationCount,
                    false,
                    true,
                    mutation,
                    crossover
                    );

                GraphicForm graphicForm = new GraphicForm(genericAlgorithmEngine, inputs.generationCount);
                graphicForm.ShowDialog();


                /*genericAlgorithmEngine.onGenerationComplete += (generation, bestFitness) =>
                {
                    bestFitnessHistory.Add(bestFitness);

                    if(generation % 10 == 0 || generation == inputs.generationCount - 1)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            UpdateChart();

                        });
                    }
                };*/

                //Individual bestIndividual = genericAlgorithmEngine.run();
                //printResults(bestIndividual);
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

        /*private void SetupChart()
        {
            // Grafik alanını temizle ve yeniden ayarla
            chart_generation.ChartAreas.Clear();
            chart_generation.Series.Clear();

            // Grafik başlığı ekle
            chart_generation.Titles.Add(new Title("Genetik Algoritma Yakınsama Grafiği"));

            // Grafik alanı ayarları
            ChartArea chartArea = new ChartArea("ConvergenceArea");
            chartArea.AxisX.Title = "Jenerasyon";
            chartArea.AxisY.Title = "En İyi Uygunluk Değeri";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Minimum = 0;
            chart_generation.ChartAreas.Add(chartArea);
            chart_generation.ChartAreas[0].AxisY.IsStartedFromZero = false;

            // Seri ayarları
            Series series = new Series("BestFitness");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Blue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 6;
            chart_generation.Series.Add(series);

            // İsterseniz ortalama fitness için ikinci bir seri ekleyebilirsiniz
            // Series avgSeries = new Series("AverageFitness");
            // avgSeries.ChartType = SeriesChartType.Line;
            // avgSeries.Color = Color.Green;
            // avgSeries.BorderWidth = 2;
            // chart_generation.Series.Add(avgSeries);
        }*/

        /*private void UpdateChart()
        {
            try
            {
                Series series = chart_generation.Series["BestFitness"];
                series.Points.Clear();

                // Verileri grafiğe ekle
                for (int i = 0; i < bestFitnessHistory.Count; i++)
                {
                    series.Points.AddXY(i, bestFitnessHistory[i]);
                }

                if (bestFitnessHistory.Count > 0)
                {
                    double minFitness = bestFitnessHistory.Min();
                    double maxFitness = bestFitnessHistory.Max();

                    // Minimum değerden biraz daha düşük, maksimum değerden biraz daha yüksek bir aralık belirle
                    double range = maxFitness - minFitness;
                    double yMin = Math.Max(0, minFitness - (range * 0.05)); // En az 0 olsun
                    double yMax = maxFitness + (range * 0.05);

                    // Y ekseni aralığını ayarla
                    chart_generation.ChartAreas[0].AxisY.Minimum = yMin;
                    chart_generation.ChartAreas[0].AxisY.Maximum = yMax;

                    // Y ekseni için otomatik aralıklandırma
                    chart_generation.ChartAreas[0].AxisY.Interval = range / 10;
                }

                // Grafik eksenlerini yeniden hesapla
                //chart_generation.ChartAreas[0].RecalculateAxesScale();

                // Grafiği yenile
                chart_generation.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grafik güncellenirken hata: {ex.Message}", "Grafik Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void printResults(Individual bestIndividual)
        {
            string resultText = $"Test Problem 6 Çözüm Sonucu:\r\n";
            resultText += $"En İyi Çözüm Parametreleri: x1 = {bestIndividual.x1Gens:F6}, x2 = {bestIndividual.x2Gens:F6}\r\n";
            resultText += $"Amaç Fonksiyon Değeri: {bestIndividual.fitnessValue:F6}\r\n";
            //resultText += $"Toplam Jenerasyon Sayısı: {generationCount}\r\n";
            //resultText += $"Popülasyon Boyutu: {populationSize}\r\n";

            //txtResults.Text = resultText;
            //UpdateChart();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
