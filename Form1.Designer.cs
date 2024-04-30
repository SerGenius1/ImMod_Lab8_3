namespace Lab_8._3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.input_NumOfTrials = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inp_p1 = new System.Windows.Forms.NumericUpDown();
            this.inp_p2 = new System.Windows.Forms.NumericUpDown();
            this.inp_p3 = new System.Windows.Forms.NumericUpDown();
            this.inp_p4 = new System.Windows.Forms.NumericUpDown();
            this.bt_Start = new System.Windows.Forms.Button();
            this.inp_p5 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.input_NumOfTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of trials";
            // 
            // input_NumOfTrials
            // 
            this.input_NumOfTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_NumOfTrials.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.input_NumOfTrials.Location = new System.Drawing.Point(180, 394);
            this.input_NumOfTrials.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input_NumOfTrials.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.input_NumOfTrials.Name = "input_NumOfTrials";
            this.input_NumOfTrials.Size = new System.Drawing.Size(120, 29);
            this.input_NumOfTrials.TabIndex = 1;
            this.input_NumOfTrials.ThousandsSeparator = true;
            this.input_NumOfTrials.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Probability 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probability 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Probability 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Probability 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Probability 5";
            // 
            // inp_p1
            // 
            this.inp_p1.DecimalPlaces = 2;
            this.inp_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p1.Location = new System.Drawing.Point(180, 75);
            this.inp_p1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p1.Name = "inp_p1";
            this.inp_p1.Size = new System.Drawing.Size(120, 29);
            this.inp_p1.TabIndex = 1;
            this.inp_p1.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // inp_p2
            // 
            this.inp_p2.DecimalPlaces = 2;
            this.inp_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p2.Location = new System.Drawing.Point(180, 128);
            this.inp_p2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p2.Name = "inp_p2";
            this.inp_p2.Size = new System.Drawing.Size(120, 29);
            this.inp_p2.TabIndex = 1;
            this.inp_p2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // inp_p3
            // 
            this.inp_p3.DecimalPlaces = 2;
            this.inp_p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p3.Location = new System.Drawing.Point(180, 182);
            this.inp_p3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p3.Name = "inp_p3";
            this.inp_p3.Size = new System.Drawing.Size(120, 29);
            this.inp_p3.TabIndex = 1;
            this.inp_p3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // inp_p4
            // 
            this.inp_p4.DecimalPlaces = 2;
            this.inp_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p4.Location = new System.Drawing.Point(180, 237);
            this.inp_p4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p4.Name = "inp_p4";
            this.inp_p4.Size = new System.Drawing.Size(120, 29);
            this.inp_p4.TabIndex = 1;
            this.inp_p4.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Start.Location = new System.Drawing.Point(90, 460);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(144, 42);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // inp_p5
            // 
            this.inp_p5.DecimalPlaces = 2;
            this.inp_p5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp_p5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inp_p5.Location = new System.Drawing.Point(180, 296);
            this.inp_p5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_p5.Name = "inp_p5";
            this.inp_p5.ReadOnly = true;
            this.inp_p5.Size = new System.Drawing.Size(120, 29);
            this.inp_p5.TabIndex = 1;
            this.inp_p5.Value = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(363, 75);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(548, 427);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 547);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.inp_p5);
            this.Controls.Add(this.inp_p4);
            this.Controls.Add(this.inp_p3);
            this.Controls.Add(this.inp_p2);
            this.Controls.Add(this.inp_p1);
            this.Controls.Add(this.input_NumOfTrials);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input_NumOfTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown input_NumOfTrials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inp_p1;
        private System.Windows.Forms.NumericUpDown inp_p2;
        private System.Windows.Forms.NumericUpDown inp_p3;
        private System.Windows.Forms.NumericUpDown inp_p4;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.NumericUpDown inp_p5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

