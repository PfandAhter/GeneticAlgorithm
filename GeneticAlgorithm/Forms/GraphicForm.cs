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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm.Forms
{
    public partial class GraphicForm : Form
    {
        private List<double> bestFitnessHistory;

        private GAEngine genericAlgorithmEngine;

        private int generationCount;
        private String thema = "#082c30";

        public GraphicForm(GAEngine _gaEngine, int generationCount)
        {
            InitializeComponent();
            genericAlgorithmEngine = _gaEngine;
            this.generationCount = generationCount;
            bestFitnessHistory = new List<double>();
            this.BackColor = ColorTranslator.FromHtml(thema);
            setupChart();
        }

        private void draw()
        {
            try
            {
                chart_generation.Series["BestFitness"].Points.Clear();
                bestFitnessHistory.Clear();

                genericAlgorithmEngine.onGenerationComplete += (generation, bestFitness) =>
                {
                    bestFitnessHistory.Add(bestFitness);

                    if (generation % 10 == 0 || generation == generationCount - 1)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            updateChart();

                        });
                    }
                };

                Individual bestIndividual = genericAlgorithmEngine.run();
                //printResults(bestIndividual);
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
        }
        private void updateChart()
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
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            draw();
        }
    }
}
