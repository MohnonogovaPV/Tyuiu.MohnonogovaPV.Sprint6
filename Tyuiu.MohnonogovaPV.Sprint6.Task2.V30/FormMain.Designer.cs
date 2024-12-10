namespace Tyuiu.MohnonogovaPV.Sprint6.Task2.V30
{
    partial class FormMain
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
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KEA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KEA = new System.Windows.Forms.TextBox();
            this.labelStop_KEA = new System.Windows.Forms.Label();
            this.labelStart_KEA = new System.Windows.Forms.Label();
            this.groupBoxResult_KEA = new System.Windows.Forms.GroupBox();
            this.chartGraf_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_KEA = new System.Windows.Forms.DataGridView();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.X_KEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxVar_KEA.SuspendLayout();
            this.groupBoxResult_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_KEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(573, 315);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTask_KEA.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(561, 284);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = "Написать программу, которая выводит таблицу значений функции: (5x + 2,5 /sin(x)+3" +
    ") + 2x + cos(x).";
            // 
            // groupBoxVar_KEA
            // 
            this.groupBoxVar_KEA.Controls.Add(this.textBoxStop_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.textBoxStart_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.labelStop_KEA);
            this.groupBoxVar_KEA.Controls.Add(this.labelStart_KEA);
            this.groupBoxVar_KEA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVar_KEA.Location = new System.Drawing.Point(6, 321);
            this.groupBoxVar_KEA.Name = "groupBoxVar_KEA";
            this.groupBoxVar_KEA.Size = new System.Drawing.Size(302, 127);
            this.groupBoxVar_KEA.TabIndex = 1;
            this.groupBoxVar_KEA.TabStop = false;
            this.groupBoxVar_KEA.Text = "Ввод данных";
            // 
            // textBoxStop_KEA
            // 
            this.textBoxStop_KEA.Location = new System.Drawing.Point(149, 43);
            this.textBoxStop_KEA.Multiline = true;
            this.textBoxStop_KEA.Name = "textBoxStop_KEA";
            this.textBoxStop_KEA.Size = new System.Drawing.Size(52, 40);
            this.textBoxStop_KEA.TabIndex = 1;
            this.textBoxStop_KEA.Text = "5";
            // 
            // textBoxStart_KEA
            // 
            this.textBoxStart_KEA.Location = new System.Drawing.Point(26, 43);
            this.textBoxStart_KEA.Multiline = true;
            this.textBoxStart_KEA.Name = "textBoxStart_KEA";
            this.textBoxStart_KEA.Size = new System.Drawing.Size(52, 40);
            this.textBoxStart_KEA.TabIndex = 2;
            this.textBoxStart_KEA.Text = "-5";
            // 
            // labelStop_KEA
            // 
            this.labelStop_KEA.AutoSize = true;
            this.labelStop_KEA.Location = new System.Drawing.Point(128, 22);
            this.labelStop_KEA.Name = "labelStop_KEA";
            this.labelStop_KEA.Size = new System.Drawing.Size(94, 18);
            this.labelStop_KEA.TabIndex = 1;
            this.labelStop_KEA.Text = "Конец шага:";
            // 
            // labelStart_KEA
            // 
            this.labelStart_KEA.AutoSize = true;
            this.labelStart_KEA.Location = new System.Drawing.Point(6, 22);
            this.labelStart_KEA.Name = "labelStart_KEA";
            this.labelStart_KEA.Size = new System.Drawing.Size(93, 18);
            this.labelStart_KEA.TabIndex = 0;
            this.labelStart_KEA.Text = "Старт шага:";
            // 
            // groupBoxResult_KEA
            // 
            this.groupBoxResult_KEA.Controls.Add(this.chartGraf_KEA);
            this.groupBoxResult_KEA.Controls.Add(this.dataGridView_KEA);
            this.groupBoxResult_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxResult_KEA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_KEA.Location = new System.Drawing.Point(579, 0);
            this.groupBoxResult_KEA.Name = "groupBoxResult_KEA";
            this.groupBoxResult_KEA.Size = new System.Drawing.Size(558, 315);
            this.groupBoxResult_KEA.TabIndex = 3;
            this.groupBoxResult_KEA.TabStop = false;
            this.groupBoxResult_KEA.Text = "Вывод данных";
            // 
            // chartGraf_KEA
            // 
            this.chartGraf_KEA.BackColor = System.Drawing.Color.MistyRose;
            chartArea1.Name = "ChartArea1";
            this.chartGraf_KEA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.ItemColumnSpacing = 100;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chartGraf_KEA.Legends.Add(legend1);
            this.chartGraf_KEA.Location = new System.Drawing.Point(277, 25);
            this.chartGraf_KEA.Name = "chartGraf_KEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf_KEA.Series.Add(series1);
            this.chartGraf_KEA.Size = new System.Drawing.Size(275, 284);
            this.chartGraf_KEA.TabIndex = 6;
            // 
            // dataGridView_KEA
            // 
            this.dataGridView_KEA.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_KEA,
            this.Y});
            this.dataGridView_KEA.Location = new System.Drawing.Point(14, 33);
            this.dataGridView_KEA.Name = "dataGridView_KEA";
            this.dataGridView_KEA.RowHeadersVisible = false;
            this.dataGridView_KEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_KEA.Size = new System.Drawing.Size(164, 276);
            this.dataGridView_KEA.TabIndex = 5;
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxResult_KEA.Location = new System.Drawing.Point(6, 25);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.ReadOnly = true;
            this.textBoxResult_KEA.Size = new System.Drawing.Size(546, 290);
            this.textBoxResult_KEA.TabIndex = 4;
            this.textBoxResult_KEA.Text = "Результат";
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(332, 365);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(57, 52);
            this.buttonHelp_KEA.TabIndex = 0;
            this.buttonHelp_KEA.Text = "?";
            this.buttonHelp_KEA.UseVisualStyleBackColor = true;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_KEA.Location = new System.Drawing.Point(408, 365);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(159, 52);
            this.buttonDone_KEA.TabIndex = 7;
            this.buttonDone_KEA.Text = "Выполнить";
            this.buttonDone_KEA.UseVisualStyleBackColor = true;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            this.buttonDone_KEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KEA_MouseDown);
            this.buttonDone_KEA.MouseEnter += new System.EventHandler(this.buttonDone_KEA_ENTER);
            this.buttonDone_KEA.MouseLeave += new System.EventHandler(this.buttonDone_KEA_LEAVE);
            // 
            // X_KEA
            // 
            this.X_KEA.HeaderText = "X";
            this.X_KEA.Name = "X_KEA";
            this.X_KEA.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            // 
            // FormMain_KEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1149, 460);
            this.Controls.Add(this.buttonDone_KEA);
            this.Controls.Add(this.buttonHelp_KEA);
            this.Controls.Add(this.groupBoxResult_KEA);
            this.Controls.Add(this.groupBoxVar_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain_KEA";
            this.Text = "Спринт 6 | Таск 2 | Вариант 30 | Мохноногова П. В.";
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxVar_KEA.ResumeLayout(false);
            this.groupBoxVar_KEA.PerformLayout();
            this.groupBoxResult_KEA.ResumeLayout(false);
            this.groupBoxResult_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_KEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxVar_KEA;
        private System.Windows.Forms.TextBox textBoxStop_KEA;
        private System.Windows.Forms.TextBox textBoxStart_KEA;
        private System.Windows.Forms.Label labelStop_KEA;
        private System.Windows.Forms.Label labelStart_KEA;
        private System.Windows.Forms.GroupBox groupBoxResult_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_KEA;
        private System.Windows.Forms.DataGridView dataGridView_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_KEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}