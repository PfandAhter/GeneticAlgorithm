namespace GeneticAlgorithm
{
    partial class MainForm
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
            this.button_Run = new System.Windows.Forms.Button();
            this.pictureBox_Test6Formula = new System.Windows.Forms.PictureBox();
            this.pictureBox_Test6SearchDomain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_TournamentSelection = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_PopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CrossoverRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MutationRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_EliteRate = new System.Windows.Forms.NumericUpDown();
            this.button_Clear = new System.Windows.Forms.Button();
            this.numericUpDown_GenerationCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PrecisionValue = new System.Windows.Forms.NumericUpDown();
            this.checkBox_RouletteSelection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Test6Formula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Test6SearchDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CrossoverRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EliteRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GenerationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PrecisionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.BackColor = System.Drawing.Color.Green;
            this.button_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Run.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Run.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Run.Location = new System.Drawing.Point(12, 442);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(339, 83);
            this.button_Run.TabIndex = 0;
            this.button_Run.Text = "Generate";
            this.button_Run.UseVisualStyleBackColor = false;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // pictureBox_Test6Formula
            // 
            this.pictureBox_Test6Formula.Location = new System.Drawing.Point(10, 78);
            this.pictureBox_Test6Formula.Name = "pictureBox_Test6Formula";
            this.pictureBox_Test6Formula.Size = new System.Drawing.Size(387, 68);
            this.pictureBox_Test6Formula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Test6Formula.TabIndex = 2;
            this.pictureBox_Test6Formula.TabStop = false;
            // 
            // pictureBox_Test6SearchDomain
            // 
            this.pictureBox_Test6SearchDomain.Location = new System.Drawing.Point(403, 78);
            this.pictureBox_Test6SearchDomain.Name = "pictureBox_Test6SearchDomain";
            this.pictureBox_Test6SearchDomain.Size = new System.Drawing.Size(181, 68);
            this.pictureBox_Test6SearchDomain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Test6SearchDomain.TabIndex = 3;
            this.pictureBox_Test6SearchDomain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test 6 Formula";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test 6 Search Domain";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Population size :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crossover Rate :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mutation Rate :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Elite Rate :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Generation Count :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_TournamentSelection
            // 
            this.checkBox_TournamentSelection.AutoSize = true;
            this.checkBox_TournamentSelection.Checked = true;
            this.checkBox_TournamentSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TournamentSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_TournamentSelection.Location = new System.Drawing.Point(315, 394);
            this.checkBox_TournamentSelection.Name = "checkBox_TournamentSelection";
            this.checkBox_TournamentSelection.Size = new System.Drawing.Size(269, 33);
            this.checkBox_TournamentSelection.TabIndex = 11;
            this.checkBox_TournamentSelection.Text = "Tournament Selection";
            this.checkBox_TournamentSelection.UseVisualStyleBackColor = true;
            this.checkBox_TournamentSelection.CheckedChanged += new System.EventHandler(this.checkBox_TournamentSelection_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precision Value :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_PopulationSize
            // 
            this.numericUpDown_PopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_PopulationSize.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_PopulationSize.Location = new System.Drawing.Point(300, 162);
            this.numericUpDown_PopulationSize.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_PopulationSize.Name = "numericUpDown_PopulationSize";
            this.numericUpDown_PopulationSize.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_PopulationSize.TabIndex = 13;
            // 
            // numericUpDown_CrossoverRate
            // 
            this.numericUpDown_CrossoverRate.DecimalPlaces = 3;
            this.numericUpDown_CrossoverRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_CrossoverRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_CrossoverRate.Location = new System.Drawing.Point(300, 201);
            this.numericUpDown_CrossoverRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CrossoverRate.Name = "numericUpDown_CrossoverRate";
            this.numericUpDown_CrossoverRate.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_CrossoverRate.TabIndex = 14;
            // 
            // numericUpDown_MutationRate
            // 
            this.numericUpDown_MutationRate.DecimalPlaces = 3;
            this.numericUpDown_MutationRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_MutationRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_MutationRate.Location = new System.Drawing.Point(300, 239);
            this.numericUpDown_MutationRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MutationRate.Name = "numericUpDown_MutationRate";
            this.numericUpDown_MutationRate.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_MutationRate.TabIndex = 15;
            // 
            // numericUpDown_EliteRate
            // 
            this.numericUpDown_EliteRate.DecimalPlaces = 3;
            this.numericUpDown_EliteRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_EliteRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_EliteRate.Location = new System.Drawing.Point(300, 277);
            this.numericUpDown_EliteRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_EliteRate.Name = "numericUpDown_EliteRate";
            this.numericUpDown_EliteRate.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_EliteRate.TabIndex = 16;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Maroon;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Clear.Location = new System.Drawing.Point(366, 442);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(218, 83);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // numericUpDown_GenerationCount
            // 
            this.numericUpDown_GenerationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_GenerationCount.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_GenerationCount.Location = new System.Drawing.Point(300, 314);
            this.numericUpDown_GenerationCount.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDown_GenerationCount.Name = "numericUpDown_GenerationCount";
            this.numericUpDown_GenerationCount.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_GenerationCount.TabIndex = 20;
            // 
            // numericUpDown_PrecisionValue
            // 
            this.numericUpDown_PrecisionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_PrecisionValue.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_PrecisionValue.Location = new System.Drawing.Point(300, 351);
            this.numericUpDown_PrecisionValue.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDown_PrecisionValue.Name = "numericUpDown_PrecisionValue";
            this.numericUpDown_PrecisionValue.Size = new System.Drawing.Size(152, 26);
            this.numericUpDown_PrecisionValue.TabIndex = 21;
            this.numericUpDown_PrecisionValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBox_RouletteSelection
            // 
            this.checkBox_RouletteSelection.AutoSize = true;
            this.checkBox_RouletteSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RouletteSelection.Location = new System.Drawing.Point(24, 394);
            this.checkBox_RouletteSelection.Name = "checkBox_RouletteSelection";
            this.checkBox_RouletteSelection.Size = new System.Drawing.Size(229, 33);
            this.checkBox_RouletteSelection.TabIndex = 22;
            this.checkBox_RouletteSelection.Text = "Roulette Selection";
            this.checkBox_RouletteSelection.UseVisualStyleBackColor = true;
            this.checkBox_RouletteSelection.CheckedChanged += new System.EventHandler(this.checkBox_RouletteSelection_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 539);
            this.Controls.Add(this.checkBox_RouletteSelection);
            this.Controls.Add(this.numericUpDown_PrecisionValue);
            this.Controls.Add(this.numericUpDown_GenerationCount);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.numericUpDown_EliteRate);
            this.Controls.Add(this.numericUpDown_MutationRate);
            this.Controls.Add(this.numericUpDown_CrossoverRate);
            this.Controls.Add(this.numericUpDown_PopulationSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_TournamentSelection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Test6SearchDomain);
            this.Controls.Add(this.pictureBox_Test6Formula);
            this.Controls.Add(this.button_Run);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Test6Formula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Test6SearchDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CrossoverRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EliteRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GenerationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PrecisionValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.PictureBox pictureBox_Test6Formula;
        private System.Windows.Forms.PictureBox pictureBox_Test6SearchDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_TournamentSelection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_PopulationSize;
        private System.Windows.Forms.NumericUpDown numericUpDown_CrossoverRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_MutationRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_EliteRate;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.NumericUpDown numericUpDown_GenerationCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_PrecisionValue;
        private System.Windows.Forms.CheckBox checkBox_RouletteSelection;
    }
}

