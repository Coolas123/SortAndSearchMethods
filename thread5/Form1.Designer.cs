namespace thread5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.MergeSortChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CountOfArrayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuickSortChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CountingSortChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.CountThreadsTextBox = new System.Windows.Forms.TextBox();
            this.BinarySearchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LinearSearchСhart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InterpolationSearchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CleanButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MergeSortChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuickSortChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountingSortChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinarySearchChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearSearchСhart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationSearchChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(524, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MergeSortChart
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10F;
            this.MergeSortChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend2";
            this.MergeSortChart.Legends.Add(legend1);
            this.MergeSortChart.Legends.Add(legend2);
            this.MergeSortChart.Location = new System.Drawing.Point(12, 12);
            this.MergeSortChart.Name = "MergeSortChart";
            this.MergeSortChart.Size = new System.Drawing.Size(350, 300);
            this.MergeSortChart.TabIndex = 2;
            this.MergeSortChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Title1";
            title1.Text = "Сортировка слиянием";
            this.MergeSortChart.Titles.Add(title1);
            // 
            // CountOfArrayTextBox
            // 
            this.CountOfArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfArrayTextBox.Location = new System.Drawing.Point(158, 659);
            this.CountOfArrayTextBox.Name = "CountOfArrayTextBox";
            this.CountOfArrayTextBox.Size = new System.Drawing.Size(164, 29);
            this.CountOfArrayTextBox.TabIndex = 5;
            this.CountOfArrayTextBox.Text = "1000000";
            this.CountOfArrayTextBox.TextChanged += new System.EventHandler(this.CountOfArrayTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ко-во элементов";
            // 
            // QuickSortChart
            // 
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 10F;
            this.QuickSortChart.ChartAreas.Add(chartArea2);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Enabled = false;
            legend4.Name = "Legend2";
            this.QuickSortChart.Legends.Add(legend3);
            this.QuickSortChart.Legends.Add(legend4);
            this.QuickSortChart.Location = new System.Drawing.Point(368, 12);
            this.QuickSortChart.Name = "QuickSortChart";
            this.QuickSortChart.Size = new System.Drawing.Size(350, 300);
            this.QuickSortChart.TabIndex = 7;
            this.QuickSortChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title2.Name = "Title1";
            title2.Text = "Быстрая сортировка";
            this.QuickSortChart.Titles.Add(title2);
            // 
            // CountingSortChart
            // 
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 80F;
            chartArea3.Position.Width = 94F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 10F;
            this.CountingSortChart.ChartAreas.Add(chartArea3);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Enabled = false;
            legend6.Name = "Legend2";
            this.CountingSortChart.Legends.Add(legend5);
            this.CountingSortChart.Legends.Add(legend6);
            this.CountingSortChart.Location = new System.Drawing.Point(724, 12);
            this.CountingSortChart.Name = "CountingSortChart";
            this.CountingSortChart.Size = new System.Drawing.Size(350, 300);
            this.CountingSortChart.TabIndex = 8;
            this.CountingSortChart.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title3.Name = "Title1";
            title3.Text = "Сортировка подсчетом";
            this.CountingSortChart.Titles.Add(title3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ко-во потоков";
            // 
            // CountThreadsTextBox
            // 
            this.CountThreadsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountThreadsTextBox.Location = new System.Drawing.Point(344, 659);
            this.CountThreadsTextBox.Name = "CountThreadsTextBox";
            this.CountThreadsTextBox.Size = new System.Drawing.Size(164, 29);
            this.CountThreadsTextBox.TabIndex = 9;
            this.CountThreadsTextBox.Text = "10";
            this.CountThreadsTextBox.TextChanged += new System.EventHandler(this.CountThreadsTextBox_TextChanged);
            // 
            // BinarySearchChart
            // 
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 80F;
            chartArea4.Position.Width = 94F;
            chartArea4.Position.X = 3F;
            chartArea4.Position.Y = 10F;
            this.BinarySearchChart.ChartAreas.Add(chartArea4);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Name = "Legend1";
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Enabled = false;
            legend8.Name = "Legend2";
            this.BinarySearchChart.Legends.Add(legend7);
            this.BinarySearchChart.Legends.Add(legend8);
            this.BinarySearchChart.Location = new System.Drawing.Point(12, 318);
            this.BinarySearchChart.Name = "BinarySearchChart";
            this.BinarySearchChart.Size = new System.Drawing.Size(350, 300);
            this.BinarySearchChart.TabIndex = 11;
            this.BinarySearchChart.Text = "chart2";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title4.Name = "Title1";
            title4.Text = "Бинарный поиск";
            this.BinarySearchChart.Titles.Add(title4);
            // 
            // LinearSearchСhart
            // 
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 80F;
            chartArea5.Position.Width = 94F;
            chartArea5.Position.X = 3F;
            chartArea5.Position.Y = 10F;
            this.LinearSearchСhart.ChartAreas.Add(chartArea5);
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend9.Name = "Legend1";
            legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend10.Enabled = false;
            legend10.Name = "Legend2";
            this.LinearSearchСhart.Legends.Add(legend9);
            this.LinearSearchСhart.Legends.Add(legend10);
            this.LinearSearchСhart.Location = new System.Drawing.Point(368, 318);
            this.LinearSearchСhart.Name = "LinearSearchСhart";
            this.LinearSearchСhart.Size = new System.Drawing.Size(350, 300);
            this.LinearSearchСhart.TabIndex = 12;
            this.LinearSearchСhart.Text = "chart2";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title5.Name = "Title1";
            title5.Text = "Линейный поиск";
            this.LinearSearchСhart.Titles.Add(title5);
            // 
            // InterpolationSearchChart
            // 
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 80F;
            chartArea6.Position.Width = 94F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 10F;
            this.InterpolationSearchChart.ChartAreas.Add(chartArea6);
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend11.Name = "Legend1";
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Enabled = false;
            legend12.Name = "Legend2";
            this.InterpolationSearchChart.Legends.Add(legend11);
            this.InterpolationSearchChart.Legends.Add(legend12);
            this.InterpolationSearchChart.Location = new System.Drawing.Point(724, 318);
            this.InterpolationSearchChart.Name = "InterpolationSearchChart";
            this.InterpolationSearchChart.Size = new System.Drawing.Size(350, 300);
            this.InterpolationSearchChart.TabIndex = 13;
            this.InterpolationSearchChart.Text = "chart2";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title6.Name = "Title1";
            title6.Text = "Интерполяционный поиск";
            this.InterpolationSearchChart.Titles.Add(title6);
            // 
            // CleanButton
            // 
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanButton.Location = new System.Drawing.Point(712, 648);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(164, 40);
            this.CleanButton.TabIndex = 14;
            this.CleanButton.Text = "Очистить";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 719);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.InterpolationSearchChart);
            this.Controls.Add(this.LinearSearchСhart);
            this.Controls.Add(this.BinarySearchChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountThreadsTextBox);
            this.Controls.Add(this.CountingSortChart);
            this.Controls.Add(this.QuickSortChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountOfArrayTextBox);
            this.Controls.Add(this.MergeSortChart);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MergeSortChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuickSortChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountingSortChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinarySearchChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearSearchСhart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationSearchChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MergeSortChart;
        private System.Windows.Forms.TextBox CountOfArrayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart QuickSortChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart CountingSortChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountThreadsTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart BinarySearchChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LinearSearchСhart;
        private System.Windows.Forms.DataVisualization.Charting.Chart InterpolationSearchChart;
        private System.Windows.Forms.Button CleanButton;
    }
}

