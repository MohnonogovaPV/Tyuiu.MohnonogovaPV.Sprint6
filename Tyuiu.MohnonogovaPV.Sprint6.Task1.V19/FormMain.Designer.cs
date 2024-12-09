namespace Tyuiu.MohnonogovaPV.Sprint6.Task1.V19
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_RKN = new GroupBox();
            pictureBoxFormula_RKN = new PictureBox();
            textBoxTask_RKN = new TextBox();
            groupBoxEnter_RKN = new GroupBox();
            textBoxStop_RKN = new TextBox();
            textBox_Stop_RKN = new TextBox();
            textBoxStart_RKN = new TextBox();
            textBox_Start_RKN = new TextBox();
            groupBoxResult_RKN = new GroupBox();
            textBoxResult_RKN = new TextBox();
            textBox_Result_RKN = new TextBox();
            buttonHelp_RKN = new Button();
            buttonResult_RKN = new Button();
            groupBoxTask_RKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).BeginInit();
            groupBoxEnter_RKN.SuspendLayout();
            groupBoxResult_RKN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_RKN
            // 
            groupBoxTask_RKN.Controls.Add(pictureBoxFormula_RKN);
            groupBoxTask_RKN.Controls.Add(textBoxTask_RKN);
            groupBoxTask_RKN.Location = new Point(14, 16);
            groupBoxTask_RKN.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_RKN.Name = "groupBoxTask_RKN";
            groupBoxTask_RKN.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_RKN.Size = new Size(634, 403);
            groupBoxTask_RKN.TabIndex = 0;
            groupBoxTask_RKN.TabStop = false;
            groupBoxTask_RKN.Text = "Условие";
            // 
            // pictureBoxFormula_RKN
            // 
            pictureBoxFormula_RKN.Image = (Image)resources.GetObject("pictureBoxFormula_RKN.Image");
            pictureBoxFormula_RKN.Location = new Point(303, 37);
            pictureBoxFormula_RKN.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_RKN.Name = "pictureBoxFormula_RKN";
            pictureBoxFormula_RKN.Size = new Size(331, 44);
            pictureBoxFormula_RKN.TabIndex = 1;
            pictureBoxFormula_RKN.TabStop = false;
            // 
            // textBoxTask_RKN
            // 
            textBoxTask_RKN.BackColor = SystemColors.Control;
            textBoxTask_RKN.BorderStyle = BorderStyle.None;
            textBoxTask_RKN.Location = new Point(14, 37);
            textBoxTask_RKN.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_RKN.Multiline = true;
            textBoxTask_RKN.Name = "textBoxTask_RKN";
            textBoxTask_RKN.ReadOnly = true;
            textBoxTask_RKN.Size = new Size(364, 72);
            textBoxTask_RKN.TabIndex = 0;
            textBoxTask_RKN.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в виде таблицы\r\n";
            // 
            // groupBoxEnter_RKN
            // 
            groupBoxEnter_RKN.Controls.Add(textBoxStop_RKN);
            groupBoxEnter_RKN.Controls.Add(textBox_Stop_RKN);
            groupBoxEnter_RKN.Controls.Add(textBoxStart_RKN);
            groupBoxEnter_RKN.Controls.Add(textBox_Start_RKN);
            groupBoxEnter_RKN.Location = new Point(14, 427);
            groupBoxEnter_RKN.Margin = new Padding(3, 4, 3, 4);
            groupBoxEnter_RKN.Name = "groupBoxEnter_RKN";
            groupBoxEnter_RKN.Padding = new Padding(3, 4, 3, 4);
            groupBoxEnter_RKN.Size = new Size(320, 145);
            groupBoxEnter_RKN.TabIndex = 1;
            groupBoxEnter_RKN.TabStop = false;
            groupBoxEnter_RKN.Text = "Ввод данных";
            // 
            // textBoxStop_RKN
            // 
            textBoxStop_RKN.BorderStyle = BorderStyle.None;
            textBoxStop_RKN.Location = new Point(185, 81);
            textBoxStop_RKN.Margin = new Padding(3, 4, 3, 4);
            textBoxStop_RKN.Name = "textBoxStop_RKN";
            textBoxStop_RKN.Size = new Size(114, 20);
            textBoxStop_RKN.TabIndex = 3;
            // 
            // textBox_Stop_RKN
            // 
            textBox_Stop_RKN.BackColor = SystemColors.Control;
            textBox_Stop_RKN.BorderStyle = BorderStyle.None;
            textBox_Stop_RKN.Location = new Point(185, 52);
            textBox_Stop_RKN.Margin = new Padding(3, 4, 3, 4);
            textBox_Stop_RKN.Name = "textBox_Stop_RKN";
            textBox_Stop_RKN.ReadOnly = true;
            textBox_Stop_RKN.Size = new Size(114, 20);
            textBox_Stop_RKN.TabIndex = 2;
            textBox_Stop_RKN.Text = "Конец шага:";
            // 
            // textBoxStart_RKN
            // 
            textBoxStart_RKN.BorderStyle = BorderStyle.None;
            textBoxStart_RKN.Location = new Point(14, 81);
            textBoxStart_RKN.Margin = new Padding(3, 4, 3, 4);
            textBoxStart_RKN.Name = "textBoxStart_RKN";
            textBoxStart_RKN.Size = new Size(114, 20);
            textBoxStart_RKN.TabIndex = 1;
            // 
            // textBox_Start_RKN
            // 
            textBox_Start_RKN.BackColor = SystemColors.Control;
            textBox_Start_RKN.BorderStyle = BorderStyle.None;
            textBox_Start_RKN.Location = new Point(14, 52);
            textBox_Start_RKN.Margin = new Padding(3, 4, 3, 4);
            textBox_Start_RKN.Name = "textBox_Start_RKN";
            textBox_Start_RKN.ReadOnly = true;
            textBox_Start_RKN.Size = new Size(114, 20);
            textBox_Start_RKN.TabIndex = 0;
            textBox_Start_RKN.Text = "Старт шага:";
            // 
            // groupBoxResult_RKN
            // 
            groupBoxResult_RKN.Controls.Add(textBoxResult_RKN);
            groupBoxResult_RKN.Controls.Add(textBox_Result_RKN);
            groupBoxResult_RKN.Location = new Point(677, 16);
            groupBoxResult_RKN.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_RKN.Name = "groupBoxResult_RKN";
            groupBoxResult_RKN.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_RKN.Size = new Size(341, 556);
            groupBoxResult_RKN.TabIndex = 2;
            groupBoxResult_RKN.TabStop = false;
            groupBoxResult_RKN.Text = "Вывод данных";
            // 
            // textBoxResult_RKN
            // 
            textBoxResult_RKN.Font = new Font("Consolas", 10F);
            textBoxResult_RKN.Location = new Point(7, 59);
            textBoxResult_RKN.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_RKN.Multiline = true;
            textBoxResult_RKN.Name = "textBoxResult_RKN";
            textBoxResult_RKN.ReadOnly = true;
            textBoxResult_RKN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_RKN.Size = new Size(326, 488);
            textBoxResult_RKN.TabIndex = 1;
            // 
            // textBox_Result_RKN
            // 
            textBox_Result_RKN.BackColor = SystemColors.Control;
            textBox_Result_RKN.BorderStyle = BorderStyle.None;
            textBox_Result_RKN.Location = new Point(7, 29);
            textBox_Result_RKN.Margin = new Padding(3, 4, 3, 4);
            textBox_Result_RKN.Name = "textBox_Result_RKN";
            textBox_Result_RKN.Size = new Size(114, 20);
            textBox_Result_RKN.TabIndex = 0;
            textBox_Result_RKN.Text = "Результат:";
            // 
            // buttonHelp_RKN
            // 
            buttonHelp_RKN.BackColor = Color.DodgerBlue;
            buttonHelp_RKN.Location = new Point(350, 481);
            buttonHelp_RKN.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_RKN.Name = "buttonHelp_RKN";
            buttonHelp_RKN.Size = new Size(104, 73);
            buttonHelp_RKN.TabIndex = 3;
            buttonHelp_RKN.Text = "Справка";
            buttonHelp_RKN.UseVisualStyleBackColor = false;
            buttonHelp_RKN.Click += buttonHelp_Click;
            // 
            // buttonResult_RKN
            // 
            buttonResult_RKN.BackColor = Color.Green;
            buttonResult_RKN.Location = new Point(461, 479);
            buttonResult_RKN.Margin = new Padding(3, 4, 3, 4);
            buttonResult_RKN.Name = "buttonResult_RKN";
            buttonResult_RKN.Size = new Size(187, 76);
            buttonResult_RKN.TabIndex = 4;
            buttonResult_RKN.Text = "Выполнить";
            buttonResult_RKN.UseVisualStyleBackColor = false;
            buttonResult_RKN.Click += bettonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 591);
            Controls.Add(buttonResult_RKN);
            Controls.Add(buttonHelp_RKN);
            Controls.Add(groupBoxResult_RKN);
            Controls.Add(groupBoxEnter_RKN);
            Controls.Add(groupBoxTask_RKN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 1  | V19 | Мохноногова П. В. ";
            groupBoxTask_RKN.ResumeLayout(false);
            groupBoxTask_RKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RKN).EndInit();
            groupBoxEnter_RKN.ResumeLayout(false);
            groupBoxEnter_RKN.PerformLayout();
            groupBoxResult_RKN.ResumeLayout(false);
            groupBoxResult_RKN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_RKN;
        private TextBox textBoxTask_RKN;
        private GroupBox groupBoxEnter_RKN;
        private TextBox textBoxStop_RKN;
        private TextBox textBox_Stop_RKN;
        private TextBox textBoxStart_RKN;
        private TextBox textBox_Start_RKN;
        private GroupBox groupBoxResult_RKN;
        private TextBox textBoxResult_RKN;
        private TextBox textBox_Result_RKN;
        private Button buttonHelp_RKN;
        private Button buttonResult_RKN;
        private PictureBox pictureBoxFormula_RKN;
    }
}