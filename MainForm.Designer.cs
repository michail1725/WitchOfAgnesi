namespace WitchOfAgnesi
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.WitchOfAgnesiChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GetChart = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.LeftBoardLabel = new System.Windows.Forms.Label();
            this.RightBoardLabel = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Label();
            this.Param = new System.Windows.Forms.Label();
            this.LeftBoardTextBox = new System.Windows.Forms.TextBox();
            this.RightBoardTextBox = new System.Windows.Forms.TextBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.ParamTextBox = new System.Windows.Forms.TextBox();
            this.ValuesTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WitchOfAgnesiChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WitchOfAgnesiChart
            // 
            this.WitchOfAgnesiChart.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.WitchOfAgnesiChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WitchOfAgnesiChart.Legends.Add(legend1);
            this.WitchOfAgnesiChart.Location = new System.Drawing.Point(23, 37);
            this.WitchOfAgnesiChart.Name = "WitchOfAgnesiChart";
            this.WitchOfAgnesiChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Верзьера Аньези";
            this.WitchOfAgnesiChart.Series.Add(series1);
            this.WitchOfAgnesiChart.Size = new System.Drawing.Size(528, 406);
            this.WitchOfAgnesiChart.TabIndex = 0;
            this.WitchOfAgnesiChart.Text = "chart";
            // 
            // GetChart
            // 
            this.GetChart.Enabled = false;
            this.GetChart.Location = new System.Drawing.Point(632, 344);
            this.GetChart.Name = "GetChart";
            this.GetChart.Size = new System.Drawing.Size(113, 34);
            this.GetChart.TabIndex = 1;
            this.GetChart.Text = "Построить график";
            this.GetChart.UseVisualStyleBackColor = true;
            this.GetChart.Click += new System.EventHandler(this.GetChart_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Enabled = false;
            this.ClearAll.Location = new System.Drawing.Point(632, 384);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(113, 34);
            this.ClearAll.TabIndex = 2;
            this.ClearAll.Text = "Очистить поля";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // LeftBoardLabel
            // 
            this.LeftBoardLabel.AutoSize = true;
            this.LeftBoardLabel.Location = new System.Drawing.Point(643, 7);
            this.LeftBoardLabel.Name = "LeftBoardLabel";
            this.LeftBoardLabel.Size = new System.Drawing.Size(86, 13);
            this.LeftBoardLabel.TabIndex = 3;
            this.LeftBoardLabel.Text = "Левая граница:";
            // 
            // RightBoardLabel
            // 
            this.RightBoardLabel.AutoSize = true;
            this.RightBoardLabel.Location = new System.Drawing.Point(643, 45);
            this.RightBoardLabel.Name = "RightBoardLabel";
            this.RightBoardLabel.Size = new System.Drawing.Size(92, 13);
            this.RightBoardLabel.TabIndex = 4;
            this.RightBoardLabel.Text = "Правая граница:";
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Location = new System.Drawing.Point(643, 84);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(30, 13);
            this.Step.TabIndex = 5;
            this.Step.Text = "Шаг:";
            // 
            // Param
            // 
            this.Param.AutoSize = true;
            this.Param.Location = new System.Drawing.Point(643, 123);
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(116, 13);
            this.Param.TabIndex = 6;
            this.Param.Text = "Значение параметра:";
            // 
            // LeftBoardTextBox
            // 
            this.LeftBoardTextBox.Location = new System.Drawing.Point(646, 23);
            this.LeftBoardTextBox.Name = "LeftBoardTextBox";
            this.LeftBoardTextBox.Size = new System.Drawing.Size(83, 20);
            this.LeftBoardTextBox.TabIndex = 7;
            this.LeftBoardTextBox.TextChanged += new System.EventHandler(this.IsEmpty);
            this.LeftBoardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTyping);
            // 
            // RightBoardTextBox
            // 
            this.RightBoardTextBox.Location = new System.Drawing.Point(646, 61);
            this.RightBoardTextBox.Name = "RightBoardTextBox";
            this.RightBoardTextBox.Size = new System.Drawing.Size(83, 20);
            this.RightBoardTextBox.TabIndex = 8;
            this.RightBoardTextBox.TextChanged += new System.EventHandler(this.IsEmpty);
            this.RightBoardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTyping);
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(646, 100);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(83, 20);
            this.StepTextBox.TabIndex = 9;
            this.StepTextBox.TextChanged += new System.EventHandler(this.IsEmpty);
            this.StepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTyping);
            // 
            // ParamTextBox
            // 
            this.ParamTextBox.Location = new System.Drawing.Point(646, 139);
            this.ParamTextBox.Name = "ParamTextBox";
            this.ParamTextBox.Size = new System.Drawing.Size(83, 20);
            this.ParamTextBox.TabIndex = 10;
            this.ParamTextBox.TextChanged += new System.EventHandler(this.IsEmpty);
            this.ParamTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTyping);
            // 
            // ValuesTable
            // 
            this.ValuesTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ValuesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValuesTable.Location = new System.Drawing.Point(588, 188);
            this.ValuesTable.Name = "ValuesTable";
            this.ValuesTable.ReadOnly = true;
            this.ValuesTable.Size = new System.Drawing.Size(200, 150);
            this.ValuesTable.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Таблица значений функции:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "График функции:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WitchofAgnesi.Properties.Resources.d1eba00161f3b50c8570fd75f6448189b165b38c;
            this.pictureBox1.Location = new System.Drawing.Point(127, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValuesTable);
            this.Controls.Add(this.ParamTextBox);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.RightBoardTextBox);
            this.Controls.Add(this.LeftBoardTextBox);
            this.Controls.Add(this.Param);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.RightBoardLabel);
            this.Controls.Add(this.LeftBoardLabel);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.GetChart);
            this.Controls.Add(this.WitchOfAgnesiChart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WitchOfAgnesi";
            ((System.ComponentModel.ISupportInitialize)(this.WitchOfAgnesiChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart WitchOfAgnesiChart;
        private System.Windows.Forms.Button GetChart;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Label LeftBoardLabel;
        private System.Windows.Forms.Label RightBoardLabel;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Label Param;
        private System.Windows.Forms.TextBox LeftBoardTextBox;
        private System.Windows.Forms.TextBox RightBoardTextBox;
        private System.Windows.Forms.TextBox StepTextBox;
        private System.Windows.Forms.TextBox ParamTextBox;
        private System.Windows.Forms.DataGridView ValuesTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

