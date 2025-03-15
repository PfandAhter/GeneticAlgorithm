namespace GeneticAlgorithm.Forms
{
    partial class GraphicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_generation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_generation)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_generation
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_generation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_generation.Legends.Add(legend1);
            this.chart_generation.Location = new System.Drawing.Point(20, 16);
            this.chart_generation.Name = "chart_generation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_generation.Series.Add(series1);
            this.chart_generation.Size = new System.Drawing.Size(1362, 691);
            this.chart_generation.TabIndex = 0;
            this.chart_generation.Text = "chart1";
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 719);
            this.Controls.Add(this.chart_generation);
            this.Name = "GraphicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicForm";
            this.Load += new System.EventHandler(this.GraphicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_generation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_generation;
    }
}