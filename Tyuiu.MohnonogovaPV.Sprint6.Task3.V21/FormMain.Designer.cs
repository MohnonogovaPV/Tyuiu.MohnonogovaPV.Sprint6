namespace Tyuiu.MohnonogovaPV.Sprint6.Task3.V21
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
            this.groupBoxTask_DVA = new System.Windows.Forms.GroupBox();
            this.labelMatrix_DVA = new System.Windows.Forms.Label();
            this.dataGridViewInPutArray_DVA = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_DVA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxResult_DVA = new System.Windows.Forms.GroupBox();
            this.labelResult_DVA = new System.Windows.Forms.Label();
            this.dataGridViewOutPutArray_DVA = new System.Windows.Forms.DataGridView();
            this.buttonDone_DVA = new System.Windows.Forms.Button();
            this.buttonHelp_DVA = new System.Windows.Forms.Button();
            this.groupBoxTask_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutArray_DVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult_DVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutArray_DVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DVA
            // 
            this.groupBoxTask_DVA.Controls.Add(this.labelMatrix_DVA);
            this.groupBoxTask_DVA.Controls.Add(this.dataGridViewInPutArray_DVA);
            this.groupBoxTask_DVA.Controls.Add(this.pictureBox1);
            this.groupBoxTask_DVA.Controls.Add(this.textBoxTask_DVA);
            this.groupBoxTask_DVA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DVA.Name = "groupBoxTask_DVA";
            this.groupBoxTask_DVA.Size = new System.Drawing.Size(423, 426);
            this.groupBoxTask_DVA.TabIndex = 0;
            this.groupBoxTask_DVA.TabStop = false;
            this.groupBoxTask_DVA.Text = "Условие:";
            // 
            // labelMatrix_DVA
            // 
            this.labelMatrix_DVA.AutoSize = true;
            this.labelMatrix_DVA.Location = new System.Drawing.Point(3, 238);
            this.labelMatrix_DVA.Name = "labelMatrix_DVA";
            this.labelMatrix_DVA.Size = new System.Drawing.Size(145, 17);
            this.labelMatrix_DVA.TabIndex = 3;
            this.labelMatrix_DVA.Text = "Начальная матрица:";
            // 
            // dataGridViewInPutArray_DVA
            // 
            this.dataGridViewInPutArray_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutArray_DVA.ColumnHeadersVisible = false;
            this.dataGridViewInPutArray_DVA.Location = new System.Drawing.Point(6, 258);
            this.dataGridViewInPutArray_DVA.Name = "dataGridViewInPutArray_DVA";
            this.dataGridViewInPutArray_DVA.RowHeadersVisible = false;
            this.dataGridViewInPutArray_DVA.RowHeadersWidth = 51;
            this.dataGridViewInPutArray_DVA.RowTemplate.Height = 24;
            this.dataGridViewInPutArray_DVA.Size = new System.Drawing.Size(338, 162);
            this.dataGridViewInPutArray_DVA.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_DVA
            // 
            this.textBoxTask_DVA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_DVA.Multiline = true;
            this.textBoxTask_DVA.Name = "textBoxTask_DVA";
            this.textBoxTask_DVA.ReadOnly = true;
            this.textBoxTask_DVA.Size = new System.Drawing.Size(411, 46);
            this.textBoxTask_DVA.TabIndex = 0;
            this.textBoxTask_DVA.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку \r\nпо возрастанию в первом столб" +
    "це.";
            // 
            // groupBoxResult_DVA
            // 
            this.groupBoxResult_DVA.Controls.Add(this.labelResult_DVA);
            this.groupBoxResult_DVA.Controls.Add(this.dataGridViewOutPutArray_DVA);
            this.groupBoxResult_DVA.Location = new System.Drawing.Point(471, 24);
            this.groupBoxResult_DVA.Name = "groupBoxResult_DVA";
            this.groupBoxResult_DVA.Size = new System.Drawing.Size(355, 356);
            this.groupBoxResult_DVA.TabIndex = 1;
            this.groupBoxResult_DVA.TabStop = false;
            this.groupBoxResult_DVA.Text = "Вывод данных:";
            // 
            // labelResult_DVA
            // 
            this.labelResult_DVA.AutoSize = true;
            this.labelResult_DVA.Location = new System.Drawing.Point(6, 27);
            this.labelResult_DVA.Name = "labelResult_DVA";
            this.labelResult_DVA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DVA.TabIndex = 3;
            this.labelResult_DVA.Text = "Результат:";
            // 
            // dataGridViewOutPutArray_DVA
            // 
            this.dataGridViewOutPutArray_DVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutArray_DVA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutArray_DVA.Location = new System.Drawing.Point(9, 56);
            this.dataGridViewOutPutArray_DVA.Name = "dataGridViewOutPutArray_DVA";
            this.dataGridViewOutPutArray_DVA.RowHeadersVisible = false;
            this.dataGridViewOutPutArray_DVA.RowHeadersWidth = 51;
            this.dataGridViewOutPutArray_DVA.RowTemplate.Height = 24;
            this.dataGridViewOutPutArray_DVA.Size = new System.Drawing.Size(340, 160);
            this.dataGridViewOutPutArray_DVA.TabIndex = 0;
            // 
            // buttonDone_DVA
            // 
            this.buttonDone_DVA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DVA.Location = new System.Drawing.Point(690, 386);
            this.buttonDone_DVA.Name = "buttonDone_DVA";
            this.buttonDone_DVA.Size = new System.Drawing.Size(136, 52);
            this.buttonDone_DVA.TabIndex = 2;
            this.buttonDone_DVA.Text = "Выполнить";
            this.buttonDone_DVA.UseVisualStyleBackColor = false;
            this.buttonDone_DVA.Click += new System.EventHandler(this.buttonDone_DVA_Click);
            // 
            // buttonHelp_DVA
            // 
            this.buttonHelp_DVA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_DVA.Location = new System.Drawing.Point(567, 386);
            this.buttonHelp_DVA.Name = "buttonHelp_DVA";
            this.buttonHelp_DVA.Size = new System.Drawing.Size(99, 52);
            this.buttonHelp_DVA.TabIndex = 3;
            this.buttonHelp_DVA.Text = "Справка";
            this.buttonHelp_DVA.UseVisualStyleBackColor = false;
            this.buttonHelp_DVA.Click += new System.EventHandler(this.buttonHelp_DVA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.buttonHelp_DVA);
            this.Controls.Add(this.buttonDone_DVA);
            this.Controls.Add(this.groupBoxResult_DVA);
            this.Controls.Add(this.groupBoxTask_DVA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 21 | Мохноногова П. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_DVA.ResumeLayout(false);
            this.groupBoxTask_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutArray_DVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult_DVA.ResumeLayout(false);
            this.groupBoxResult_DVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutArray_DVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxResult_DVA;
        private System.Windows.Forms.Button buttonDone_DVA;
        private System.Windows.Forms.Button buttonHelp_DVA;
        private System.Windows.Forms.TextBox textBoxTask_DVA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewInPutArray_DVA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutArray_DVA;
        private System.Windows.Forms.Label labelMatrix_DVA;
        private System.Windows.Forms.Label labelResult_DVA;
    }
}