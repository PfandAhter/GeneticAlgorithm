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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_generation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_GenerationValues = new System.Windows.Forms.DataGridView();
            this.label_GenerationValues = new System.Windows.Forms.Label();
            this.panel_BestFitness = new System.Windows.Forms.Panel();
            this.label_BestFitness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Genom = new System.Windows.Forms.Label();
            this.label_DecimalNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_FitnessValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_X1Length = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_X2Length = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.generation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decimalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart_generation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GenerationValues)).BeginInit();
            this.panel_BestFitness.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_generation
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_generation.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_generation.Legends.Add(legend7);
            this.chart_generation.Location = new System.Drawing.Point(20, 16);
            this.chart_generation.Name = "chart_generation";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart_generation.Series.Add(series7);
            this.chart_generation.Size = new System.Drawing.Size(1362, 691);
            this.chart_generation.TabIndex = 0;
            this.chart_generation.Text = "chart1";
            // 
            // dataGridView_GenerationValues
            // 
            this.dataGridView_GenerationValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GenerationValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.generation,
            this.decimalValue,
            this.fitness});
            this.dataGridView_GenerationValues.Location = new System.Drawing.Point(1395, 74);
            this.dataGridView_GenerationValues.Name = "dataGridView_GenerationValues";
            this.dataGridView_GenerationValues.Size = new System.Drawing.Size(404, 369);
            this.dataGridView_GenerationValues.TabIndex = 1;
            // 
            // label_GenerationValues
            // 
            this.label_GenerationValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GenerationValues.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_GenerationValues.Location = new System.Drawing.Point(1395, 16);
            this.label_GenerationValues.Name = "label_GenerationValues";
            this.label_GenerationValues.Size = new System.Drawing.Size(386, 43);
            this.label_GenerationValues.TabIndex = 2;
            this.label_GenerationValues.Text = "Jenerasyon degerleri";
            this.label_GenerationValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_BestFitness
            // 
            this.panel_BestFitness.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_BestFitness.Controls.Add(this.label_X2Length);
            this.panel_BestFitness.Controls.Add(this.label8);
            this.panel_BestFitness.Controls.Add(this.label_X1Length);
            this.panel_BestFitness.Controls.Add(this.label6);
            this.panel_BestFitness.Controls.Add(this.label_FitnessValue);
            this.panel_BestFitness.Controls.Add(this.label4);
            this.panel_BestFitness.Controls.Add(this.label_DecimalNumber);
            this.panel_BestFitness.Controls.Add(this.label3);
            this.panel_BestFitness.Controls.Add(this.label_Genom);
            this.panel_BestFitness.Controls.Add(this.label1);
            this.panel_BestFitness.Location = new System.Drawing.Point(1395, 502);
            this.panel_BestFitness.Name = "panel_BestFitness";
            this.panel_BestFitness.Size = new System.Drawing.Size(404, 205);
            this.panel_BestFitness.TabIndex = 3;
            // 
            // label_BestFitness
            // 
            this.label_BestFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BestFitness.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_BestFitness.Location = new System.Drawing.Point(1395, 455);
            this.label_BestFitness.Name = "label_BestFitness";
            this.label_BestFitness.Size = new System.Drawing.Size(386, 35);
            this.label_BestFitness.TabIndex = 4;
            this.label_BestFitness.Text = "Best Fitness";
            this.label_BestFitness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Genom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Genom
            // 
            this.label_Genom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Genom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Genom.Location = new System.Drawing.Point(84, 20);
            this.label_Genom.Name = "label_Genom";
            this.label_Genom.Size = new System.Drawing.Size(317, 35);
            this.label_Genom.TabIndex = 6;
            this.label_Genom.Text = "GenomList";
            this.label_Genom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_DecimalNumber
            // 
            this.label_DecimalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecimalNumber.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_DecimalNumber.Location = new System.Drawing.Point(94, 66);
            this.label_DecimalNumber.Name = "label_DecimalNumber";
            this.label_DecimalNumber.Size = new System.Drawing.Size(283, 35);
            this.label_DecimalNumber.TabIndex = 8;
            this.label_DecimalNumber.Text = "Decimal Value";
            this.label_DecimalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(-7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decimal :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_FitnessValue
            // 
            this.label_FitnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FitnessValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_FitnessValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_FitnessValue.Location = new System.Drawing.Point(98, 110);
            this.label_FitnessValue.Name = "label_FitnessValue";
            this.label_FitnessValue.Size = new System.Drawing.Size(279, 35);
            this.label_FitnessValue.TabIndex = 10;
            this.label_FitnessValue.Text = "Fitness Value";
            this.label_FitnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(-6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fitness :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_X1Length
            // 
            this.label_X1Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X1Length.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_X1Length.Location = new System.Drawing.Point(121, 156);
            this.label_X1Length.Name = "label_X1Length";
            this.label_X1Length.Size = new System.Drawing.Size(37, 35);
            this.label_X1Length.TabIndex = 12;
            this.label_X1Length.Text = "X1";
            this.label_X1Length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "X1 Length :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_X2Length
            // 
            this.label_X2Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X2Length.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_X2Length.Location = new System.Drawing.Point(310, 156);
            this.label_X2Length.Name = "label_X2Length";
            this.label_X2Length.Size = new System.Drawing.Size(37, 35);
            this.label_X2Length.TabIndex = 14;
            this.label_X2Length.Text = "X2";
            this.label_X2Length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(196, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 35);
            this.label8.TabIndex = 13;
            this.label8.Text = "X2 Length :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // generation
            // 
            this.generation.HeaderText = "Jenerasyon";
            this.generation.Name = "generation";
            this.generation.Width = 70;
            // 
            // decimalValue
            // 
            this.decimalValue.HeaderText = "Sayi";
            this.decimalValue.Name = "decimalValue";
            // 
            // fitness
            // 
            this.fitness.HeaderText = "Fitness Degeri";
            this.fitness.Name = "fitness";
            this.fitness.Width = 190;
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 719);
            this.Controls.Add(this.label_BestFitness);
            this.Controls.Add(this.panel_BestFitness);
            this.Controls.Add(this.label_GenerationValues);
            this.Controls.Add(this.dataGridView_GenerationValues);
            this.Controls.Add(this.chart_generation);
            this.Name = "GraphicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicForm";
            this.Load += new System.EventHandler(this.GraphicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_generation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GenerationValues)).EndInit();
            this.panel_BestFitness.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_generation;
        private System.Windows.Forms.DataGridView dataGridView_GenerationValues;
        private System.Windows.Forms.Label label_GenerationValues;
        private System.Windows.Forms.Panel panel_BestFitness;
        private System.Windows.Forms.Label label_BestFitness;
        private System.Windows.Forms.Label label_Genom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DecimalNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_FitnessValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_X2Length;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_X1Length;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn generation;
        private System.Windows.Forms.DataGridViewTextBoxColumn decimalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn fitness;
    }
}