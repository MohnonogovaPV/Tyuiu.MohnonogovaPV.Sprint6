namespace Tyuiu.MohnonogovaPV.Sprint6.Task7.V3
{
    partial class FormAbout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KDY = new Panel();
            buttonSaveFile_KDY = new Button();
            buttonHelp_KDY = new Button();
            buttonDone_KDY = new Button();
            buttonOpenFile_KDY = new Button();
            panelTopTop_KDY = new Panel();
            groupBoxTask_KDY = new GroupBox();
            textBoxTask_KDY = new TextBox();
            panelLeft_KDY = new Panel();
            groupBoxInPutData_KDY = new GroupBox();
            dataGridViewInMatrix_KDY = new DataGridView();
            splitter1 = new Splitter();
            panelRight_KDY = new Panel();
            groupBoxResult_KDY = new GroupBox();
            dataGridViewOutMatrix_KDY = new DataGridView();
            openFileDialogTask_KDY = new OpenFileDialog();
            toolTipButton_KDY = new ToolTip(components);
            saveFileDialogMatrix_KDY = new SaveFileDialog();
            panelTop_KDY.SuspendLayout();
            panelTopTop_KDY.SuspendLayout();
            groupBoxTask_KDY.SuspendLayout();
            panelLeft_KDY.SuspendLayout();
            groupBoxInPutData_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_KDY).BeginInit();
            panelRight_KDY.SuspendLayout();
            groupBoxResult_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_KDY).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KDY
            // 
            panelTop_KDY.Controls.Add(buttonSaveFile_KDY);
            panelTop_KDY.Controls.Add(buttonHelp_KDY);
            panelTop_KDY.Controls.Add(buttonDone_KDY);
            panelTop_KDY.Controls.Add(buttonOpenFile_KDY);
            panelTop_KDY.Dock = DockStyle.Top;
            panelTop_KDY.Location = new Point(0, 0);
            panelTop_KDY.Name = "panelTop_KDY";
            panelTop_KDY.Size = new Size(2042, 189);
            panelTop_KDY.TabIndex = 0;
            // 
            // buttonSaveFile_KDY
            // 
            buttonSaveFile_KDY.Image = (Image)resources.GetObject("buttonSaveFile_KDY.Image");
            buttonSaveFile_KDY.Location = new Point(529, 0);
            buttonSaveFile_KDY.Name = "buttonSaveFile_KDY";
            buttonSaveFile_KDY.Padding = new Padding(5);
            buttonSaveFile_KDY.Size = new Size(261, 187);
            buttonSaveFile_KDY.TabIndex = 4;
            toolTipButton_KDY.SetToolTip(buttonSaveFile_KDY, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_KDY.UseVisualStyleBackColor = true;
            buttonSaveFile_KDY.Click += buttonSaveFile_KDY_Click;
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDY.Image = (Image)resources.GetObject("buttonHelp_KDY.Image");
            buttonHelp_KDY.Location = new Point(1789, 2);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Padding = new Padding(5);
            buttonHelp_KDY.Size = new Size(253, 187);
            buttonHelp_KDY.TabIndex = 3;
            toolTipButton_KDY.SetToolTip(buttonHelp_KDY, "Сведение о программе");
            buttonHelp_KDY.UseVisualStyleBackColor = true;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.Image = (Image)resources.GetObject("buttonDone_KDY.Image");
            buttonDone_KDY.Location = new Point(262, 0);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Padding = new Padding(5);
            buttonDone_KDY.Size = new Size(261, 187);
            buttonDone_KDY.TabIndex = 2;
            toolTipButton_KDY.SetToolTip(buttonDone_KDY, "Выполнить обработку данных");
            buttonDone_KDY.UseVisualStyleBackColor = true;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            buttonDone_KDY.MouseEnter += buttonDone_KDY_MouseEnter;
            // 
            // buttonOpenFile_KDY
            // 
            buttonOpenFile_KDY.Image = (Image)resources.GetObject("buttonOpenFile_KDY.Image");
            buttonOpenFile_KDY.Location = new Point(3, 0);
            buttonOpenFile_KDY.Name = "buttonOpenFile_KDY";
            buttonOpenFile_KDY.Size = new Size(253, 187);
            buttonOpenFile_KDY.TabIndex = 1;
            toolTipButton_KDY.SetToolTip(buttonOpenFile_KDY, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_KDY.UseVisualStyleBackColor = true;
            buttonOpenFile_KDY.Click += buttonOpenFile_KDY_Click;
            buttonOpenFile_KDY.MouseEnter += buttonOpenFile_KDY_MouseEnter;
            // 
            // panelTopTop_KDY
            // 
            panelTopTop_KDY.Controls.Add(groupBoxTask_KDY);
            panelTopTop_KDY.Dock = DockStyle.Top;
            panelTopTop_KDY.Location = new Point(0, 189);
            panelTopTop_KDY.Name = "panelTopTop_KDY";
            panelTopTop_KDY.Size = new Size(2042, 134);
            panelTopTop_KDY.TabIndex = 1;
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(textBoxTask_KDY);
            groupBoxTask_KDY.Dock = DockStyle.Fill;
            groupBoxTask_KDY.Location = new Point(0, 0);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Padding = new Padding(5);
            groupBoxTask_KDY.Size = new Size(2042, 134);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие:";
            // 
            // textBoxTask_KDY
            // 
            textBoxTask_KDY.Dock = DockStyle.Fill;
            textBoxTask_KDY.Location = new Point(5, 37);
            textBoxTask_KDY.Multiline = true;
            textBoxTask_KDY.Name = "textBoxTask_KDY";
            textBoxTask_KDY.ReadOnly = true;
            textBoxTask_KDY.Size = new Size(2032, 92);
            textBoxTask_KDY.TabIndex = 0;
            textBoxTask_KDY.Text = resources.GetString("textBoxTask_KDY.Text");
            // 
            // panelLeft_KDY
            // 
            panelLeft_KDY.Controls.Add(groupBoxInPutData_KDY);
            panelLeft_KDY.Dock = DockStyle.Left;
            panelLeft_KDY.Location = new Point(0, 323);
            panelLeft_KDY.Name = "panelLeft_KDY";
            panelLeft_KDY.Size = new Size(1069, 504);
            panelLeft_KDY.TabIndex = 1;
            // 
            // groupBoxInPutData_KDY
            // 
            groupBoxInPutData_KDY.Controls.Add(dataGridViewInMatrix_KDY);
            groupBoxInPutData_KDY.Dock = DockStyle.Fill;
            groupBoxInPutData_KDY.Location = new Point(0, 0);
            groupBoxInPutData_KDY.Name = "groupBoxInPutData_KDY";
            groupBoxInPutData_KDY.Padding = new Padding(5);
            groupBoxInPutData_KDY.Size = new Size(1069, 504);
            groupBoxInPutData_KDY.TabIndex = 0;
            groupBoxInPutData_KDY.TabStop = false;
            groupBoxInPutData_KDY.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_KDY
            // 
            dataGridViewInMatrix_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_KDY.ColumnHeadersVisible = false;
            dataGridViewInMatrix_KDY.Dock = DockStyle.Fill;
            dataGridViewInMatrix_KDY.Location = new Point(5, 37);
            dataGridViewInMatrix_KDY.Name = "dataGridViewInMatrix_KDY";
            dataGridViewInMatrix_KDY.ReadOnly = true;
            dataGridViewInMatrix_KDY.RowHeadersVisible = false;
            dataGridViewInMatrix_KDY.RowHeadersWidth = 82;
            dataGridViewInMatrix_KDY.ScrollBars = ScrollBars.Vertical;
            dataGridViewInMatrix_KDY.Size = new Size(1059, 462);
            dataGridViewInMatrix_KDY.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(1069, 323);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 504);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelRight_KDY
            // 
            panelRight_KDY.Controls.Add(groupBoxResult_KDY);
            panelRight_KDY.Dock = DockStyle.Right;
            panelRight_KDY.Location = new Point(1075, 323);
            panelRight_KDY.Name = "panelRight_KDY";
            panelRight_KDY.Size = new Size(967, 504);
            panelRight_KDY.TabIndex = 3;
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(dataGridViewOutMatrix_KDY);
            groupBoxResult_KDY.Dock = DockStyle.Fill;
            groupBoxResult_KDY.Location = new Point(0, 0);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Padding = new Padding(5);
            groupBoxResult_KDY.Size = new Size(967, 504);
            groupBoxResult_KDY.TabIndex = 0;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_KDY
            // 
            dataGridViewOutMatrix_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_KDY.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_KDY.Dock = DockStyle.Fill;
            dataGridViewOutMatrix_KDY.Location = new Point(5, 37);
            dataGridViewOutMatrix_KDY.Name = "dataGridViewOutMatrix_KDY";
            dataGridViewOutMatrix_KDY.ReadOnly = true;
            dataGridViewOutMatrix_KDY.RowHeadersVisible = false;
            dataGridViewOutMatrix_KDY.RowHeadersWidth = 82;
            dataGridViewOutMatrix_KDY.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutMatrix_KDY.Size = new Size(957, 462);
            dataGridViewOutMatrix_KDY.TabIndex = 0;
            // 
            // openFileDialogTask_KDY
            // 
            openFileDialogTask_KDY.FileName = "openFileDialog1";
            // 
            // toolTipButton_KDY
            // 
            toolTipButton_KDY.IsBalloon = true;
            toolTipButton_KDY.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2042, 827);
            Controls.Add(panelRight_KDY);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_KDY);
            Controls.Add(panelTopTop_KDY);
            Controls.Add(panelTop_KDY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск7 | Вариант 3 | Храпов Д.Ю.";
            Load += FormMain_Load_1;
            panelTop_KDY.ResumeLayout(false);
            panelTopTop_KDY.ResumeLayout(false);
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            panelLeft_KDY.ResumeLayout(false);
            groupBoxInPutData_KDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_KDY).EndInit();
            panelRight_KDY.ResumeLayout(false);
            groupBoxResult_KDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KDY;
        private Panel panelTopTop_KDY;
        private Panel panelLeft_KDY;
        private Button buttonOpenFile_KDY;
        private Splitter splitter1;
        private Panel panelRight_KDY;
        private GroupBox groupBoxTask_KDY;
        private TextBox textBoxTask_KDY;
        private Button buttonDone_KDY;
        private Button buttonSaveFile_KDY;
        private Button buttonHelp_KDY;
        private GroupBox groupBoxInPutData_KDY;
        private DataGridView dataGridViewInMatrix_KDY;
        private GroupBox groupBoxResult_KDY;
        private DataGridView dataGridViewOutMatrix_KDY;
        private OpenFileDialog openFileDialogTask_KDY;
        private ToolTip toolTipButton_KDY;
        private SaveFileDialog saveFileDialogMatrix_KDY;
    }
}