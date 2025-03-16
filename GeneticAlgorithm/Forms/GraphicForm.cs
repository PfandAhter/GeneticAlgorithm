using GeneticAlgorithm.Crossover;
using GeneticAlgorithm.Exceptions;
using GeneticAlgorithm.Mutation;
using GeneticAlgorithm.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm.Forms
{
    public partial class GraphicForm : Form
    {
        private List<double> bestFitnessHistory;

        private GAEngine genericAlgorithmEngine;


        private String thema = "#082c30";

        public GraphicForm(GAEngine _gaEngine)
        {
            InitializeComponent();
            genericAlgorithmEngine = _gaEngine;
            bestFitnessHistory = new List<double>();
            this.BackColor = ColorTranslator.FromHtml(thema);
            dataGridView_GenerationValues.Rows.Clear();
            setupChart();
        }

        private void draw()
        {
            try
            {
                chart_generation.Series["BestFitness"].Points.Clear();
                bestFitnessHistory.Clear();

                genericAlgorithmEngine.onGenerationComplete += (generation, bestIndividual) =>
                {
                    bestFitnessHistory.Add(bestIndividual.fitnessValue);
                    fillDataGridView(generation, bestIndividual);
                    
                    this.Invoke((MethodInvoker)delegate
                    {
                        updateChart();
                    });
                };

                Task.Run(() =>
                {
                    Individual bestIndividual = genericAlgorithmEngine.run();

                    this.Invoke((MethodInvoker)delegate
                    {
                        // Algoritma tamamlandığında yapılacaklar
                        label_X1Length.Text = bestIndividual.x1Gens.Length.ToString();
                        label_X2Length.Text = bestIndividual.x2Gens.Length.ToString();
                        label_FitnessValue.Text = bestIndividual.fitnessValue.ToString();
                        label_DecimalNumber.Text = bestIndividual.decimalValue.ToString();
                        label_Genom.Text = string.Join("", bestIndividual.genes.Select(gene => gene ? "1" : "0"));
                    });
                });
            }
            catch (IncorretInputException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setupChart()
        {
            // Grafik alanını temizle ve yeniden ayarla
            chart_generation.ChartAreas.Clear();
            chart_generation.Series.Clear();

            // Grafik başlığı ekle
            Title title = new Title("Genetik Algoritma Yakınsama Grafiği");
            title.Font = new Font("Arial", 20, FontStyle.Bold);
            chart_generation.Titles.Add(title);

            // Grafik alanı ayarları
            ChartArea chartArea = new ChartArea("ConvergenceArea");
            chartArea.AxisX.Title = "Jenerasyon";
            chartArea.AxisY.Title = "Fitness degeri";
            chartArea.AxisX.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            chartArea.AxisY.TitleFont = new Font("Arial", 20, FontStyle.Bold);

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
        }
        private void updateChart()
        {
            try
            {
                Series series = chart_generation.Series["BestFitness"];

                // Tüm verileri temizlemek yerine sadece son jenerasyonun verisini ekleyin
                if (bestFitnessHistory.Count > 0)
                {
                    int lastIndex = bestFitnessHistory.Count-1;

                    if(bestFitnessHistory.Count == 100)
                    {
                        MessageBox.Show("100 oldu count");
                    }

                    if(lastIndex == 99)
                    {
                        MessageBox.Show("99 oldu count");
                    }
                    series.Points.AddXY(lastIndex, bestFitnessHistory[lastIndex]);
                }

                // Grafiği yenile
                chart_generation.Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Grafik güncellenirken hata: {ex.Message}");
            }
        }

        private void fillDataGridView(int generation, Individual bestIndividual)
        {
            if (dataGridView_GenerationValues.InvokeRequired)
            {
                dataGridView_GenerationValues.Invoke(new Action(() => fillDataGridView(generation, bestIndividual)));
            }
            else
            {
                dataGridView_GenerationValues.Rows.Add(
                    generation.ToString(),
                    bestIndividual.decimalValue.ToString(),
                    bestIndividual.fitnessValue.ToString()
                );
            }
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            draw();
        }
    }
}
