namespace Tyuiu.MohnonogovaPV.Sprint6.Task0.V23
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
            textBoxVarX_LED = new TextBox();
            buttonDone_LED = new Button();
            textBoxResult_LED = new TextBox();
            buttonHelp_LED = new Button();
            groupBoxTask_LED = new GroupBox();
            textBoxTask_LED = new TextBox();
            pictureBoxFormula_LED = new PictureBox();
            groupBoxResult_LED = new GroupBox();
            groupBoxVarX_LED = new GroupBox();
            textBox1 = new TextBox();
            groupBoxTask_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_LED).BeginInit();
            groupBoxResult_LED.SuspendLayout();
            groupBoxVarX_LED.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxVarX_LED
            // 
            textBoxVarX_LED.Location = new Point(69, 76);
            textBoxVarX_LED.Name = "textBoxVarX_LED";
            textBoxVarX_LED.Size = new Size(175, 27);
            textBoxVarX_LED.TabIndex = 0;
            textBoxVarX_LED.KeyPress += textBoxVarX_LED_KeyPress;
            // 
            // buttonDone_LED
            // 
            buttonDone_LED.Location = new Point(626, 419);
            buttonDone_LED.Name = "buttonDone_LED";
            buttonDone_LED.Size = new Size(131, 29);
            buttonDone_LED.TabIndex = 1;
            buttonDone_LED.Text = "Выполнить";
            buttonDone_LED.UseVisualStyleBackColor = true;
            buttonDone_LED.Click += buttonDone_LED_Click;
            // 
            // textBoxResult_LED
            // 
            textBoxResult_LED.Location = new Point(40, 26);
            textBoxResult_LED.Name = "textBoxResult_LED";
            textBoxResult_LED.ReadOnly = true;
            textBoxResult_LED.Size = new Size(125, 27);
            textBoxResult_LED.TabIndex = 2;
            // 
            // buttonHelp_LED
            // 
            buttonHelp_LED.FlatStyle = FlatStyle.Flat;
            buttonHelp_LED.Location = new Point(573, 419);
            buttonHelp_LED.Name = "buttonHelp_LED";
            buttonHelp_LED.Size = new Size(47, 29);
            buttonHelp_LED.TabIndex = 3;
            buttonHelp_LED.Text = "?";
            buttonHelp_LED.UseVisualStyleBackColor = true;
            buttonHelp_LED.Click += buttonHelp_LED_Click;
            // 
            // groupBoxTask_LED
            // 
            groupBoxTask_LED.Controls.Add(textBoxTask_LED);
            groupBoxTask_LED.Controls.Add(pictureBoxFormula_LED);
            groupBoxTask_LED.Location = new Point(29, 44);
            groupBoxTask_LED.Name = "groupBoxTask_LED";
            groupBoxTask_LED.Size = new Size(728, 212);
            groupBoxTask_LED.TabIndex = 4;
            groupBoxTask_LED.TabStop = false;
            groupBoxTask_LED.Text = "Условие:";
            // 
            // textBoxTask_LED
            // 
            textBoxTask_LED.Location = new Point(6, 26);
            textBoxTask_LED.Name = "textBoxTask_LED";
            textBoxTask_LED.Size = new Size(270, 27);
            textBoxTask_LED.TabIndex = 0;
            textBoxTask_LED.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_LED
            // 
            pictureBoxFormula_LED.Image = (Image)resources.GetObject("pictureBoxFormula_LED.Image");
            pictureBoxFormula_LED.Location = new Point(544, 15);
            pictureBoxFormula_LED.Name = "pictureBoxFormula_LED";
            pictureBoxFormula_LED.Size = new Size(125, 53);
            pictureBoxFormula_LED.TabIndex = 6;
            pictureBoxFormula_LED.TabStop = false;
            // 
            // groupBoxResult_LED
            // 
            groupBoxResult_LED.Controls.Add(textBoxResult_LED);
            groupBoxResult_LED.Location = new Point(511, 291);
            groupBoxResult_LED.Name = "groupBoxResult_LED";
            groupBoxResult_LED.Size = new Size(197, 74);
            groupBoxResult_LED.TabIndex = 7;
            groupBoxResult_LED.TabStop = false;
            groupBoxResult_LED.Text = "Результат";
            // 
            // groupBoxVarX_LED
            // 
            groupBoxVarX_LED.Controls.Add(textBox1);
            groupBoxVarX_LED.Controls.Add(textBoxVarX_LED);
            groupBoxVarX_LED.Location = new Point(29, 262);
            groupBoxVarX_LED.Name = "groupBoxVarX_LED";
            groupBoxVarX_LED.Size = new Size(364, 188);
            groupBoxVarX_LED.TabIndex = 7;
            groupBoxVarX_LED.TabStop = false;
            groupBoxVarX_LED.Text = "Ввод данных:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(90, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Переменная Х:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 460);
            Controls.Add(groupBoxVarX_LED);
            Controls.Add(groupBoxResult_LED);
            Controls.Add(buttonHelp_LED);
            Controls.Add(buttonDone_LED);
            Controls.Add(groupBoxTask_LED);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Мохноногова П. В.";
            groupBoxTask_LED.ResumeLayout(false);
            groupBoxTask_LED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_LED).EndInit();
            groupBoxResult_LED.ResumeLayout(false);
            groupBoxResult_LED.PerformLayout();
            groupBoxVarX_LED.ResumeLayout(false);
            groupBoxVarX_LED.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxVarX_LED;
        private Button buttonDone_LED;
        private TextBox textBoxResult_LED;
        private Button buttonHelp_LED;
        private GroupBox groupBoxTask_LED;
        private TextBox textBoxTask_LED;
        private PictureBox pictureBoxFormula_LED;
        private GroupBox groupBoxResult_LED;
        private GroupBox groupBoxVarX_LED;
        private TextBox textBox1;
    }
}