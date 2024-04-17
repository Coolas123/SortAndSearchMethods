using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace thread5
{
    public partial class Form1 : Form
    {
        private Random Random = new Random();
        Stopwatch watch;
        private int N = 1_000_000;
        private int CountSeries=0;
        private int CountThreads=10;
        private int[][] array;
        private Color color1;
        private Color color2;
        public Form1() {
            InitializeComponent();
            watch = new Stopwatch();
            array=new int[10][];
            FillArray();
            BinarySearchChart.ChartAreas[0].AxisY.Maximum = 0.001;
            InterpolationSearchChart.ChartAreas[0].AxisY.Maximum = 0.0001;
        }
        

        private void button1_Click(object sender, EventArgs e) {
            color1 = Color.FromArgb(Random.Next(255), Random.Next(255), Random.Next(255));
            color2 = Color.FromArgb(Random.Next(255), Random.Next(255), Random.Next(255));
            CountSeries++;

            Sort(array, CountThreads, QuickSortChart ,QuickSort.SequencSort, QuickSort.ParallelSort);

            Sort(array, CountThreads, CountingSortChart ,CountingSort.SequencSort, CountingSort.ParallelSort);

            var sortArray = Sort(array, CountThreads, MergeSortChart ,MergeSort.SequencSort, MergeSort.ParallelSort);

            Search(sortArray, CountThreads, BinarySearchChart, BinarySearch.SequencSearch, BinarySearch.ParallelSearch);

            Search(sortArray, CountThreads, LinearSearchСhart, LinearSearch.SequencSearch, LinearSearch.ParallelSearch);

            Search(sortArray, CountThreads, InterpolationSearchChart, InterpolationSearch.SequencSearch, InterpolationSearch.ParallelSearch);
        }

        private void FillArray() {
            int count = 0;
            for (int i = N / 10; i <= N; i += N / 10) {
                array[count] = new int[i];
                for (var j = 0; j < i; j++) {
                    array[count][j] = Random.Next(i);
                }
                count++;
            }
        }

        private int[][] Sort(int[][] array, int countThreads,Chart chart, Func<int[], int[]> sortMethod, Func<int[],int, int[]> parallelSortMethod) {
            if (CountSeries == 1) {
                var arrayCopy = CopyArray(array);
                chart.Series.Add(CreateSeries(color1, $"Последовательно №{CountSeries}"));
                chart.ChartAreas[0].AxisX.Minimum = N / 10;
                chart.ChartAreas[0].AxisX.Maximum = N;
                for (int i = 0; i < 10; i++) {
                    watch.Start();
                    sortMethod(arrayCopy[i]);
                    watch.Stop();

                    chart.Series[0].Points.AddXY(arrayCopy[i].Length, watch.Elapsed.TotalSeconds);
                    watch.Reset();
                }
            }
            if (CountSeries >= 1) {
                var arrayCopy = CopyArray(array);
                chart.Series.Add(CreateSeries(color2, $"Параллельно №{CountSeries}, {countThreads} потоков"));
                for (int i = 0; i < 10; i++) {
                    watch.Start();
                    parallelSortMethod(arrayCopy[i], countThreads);
                    watch.Stop();

                    chart.Series[CountSeries].Points.AddXY(arrayCopy[i].Length, watch.Elapsed.TotalSeconds);
                    watch.Reset();
                }
                return arrayCopy;
            }
            return null;
        }

        private void Search(int[][] array, int countThreads, Chart chart, Func<int[], int> searchMethod, Func<int[], int,int> parallelSearchMethod) {
            if (CountSeries == 1) {
                var arrayCopy = CopyArray(array);
                chart.Series.Add(CreateSeries(color1, $"Последовательно №{CountSeries}"));
                chart.ChartAreas[0].AxisX.Minimum = N / 10;
                chart.ChartAreas[0].AxisX.Maximum = N;
                for (int i = 0; i < 10; i++) {
                    watch.Start();
                    searchMethod(arrayCopy[i]);
                    watch.Stop();

                    chart.Series[0].Points.AddXY(arrayCopy[i].Length, watch.Elapsed.TotalSeconds);
                    watch.Reset();
                }
            }
            if (CountSeries >= 1) {
                var arrayCopy = CopyArray(array);
                chart.Series.Add(CreateSeries(color2, $"Параллельно №{CountSeries}, {countThreads} потоков"));
                for (int i = 0; i < 10; i++) {
                    watch.Start();
                    parallelSearchMethod(arrayCopy[i], countThreads);
                    watch.Stop();

                    chart.Series[CountSeries].Points.AddXY(arrayCopy[i].Length, watch.Elapsed.TotalSeconds);
                    watch.Reset();
                }
            }
        }

        private void CountOfArrayTextBox_TextChanged(object sender, EventArgs e) {
            try {
                N = int.Parse(CountOfArrayTextBox.Text);
                FillArray();
            }
            catch {
                CountOfArrayTextBox.Text = N.ToString();
                MessageBox.Show("Введите число");
            }
        }
        private Series CreateSeries(Color color, string name) {
            var series = new Series();
            series.Color = color;
            series.ChartType = SeriesChartType.Spline;
            series.Name = name;
            series.BorderWidth = 3;
            return series;
        }

        private void CountThreadsTextBox_TextChanged(object sender, EventArgs e) {
            try {
                CountThreads = int.Parse(CountThreadsTextBox.Text);
            }
            catch {
                CountThreadsTextBox.Text = CountThreads.ToString();
                MessageBox.Show("Введите число");
            }
        }
        private int[][] CopyArray(int[][]array) {
            var newArray = new int[10][];
            for (int i = 0; i < 10; i++) {
                newArray[i] = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++) {
                    newArray[i][j] = array[i][j];
                }
            }
            return newArray;
        }

        private void CleanButton_Click(object sender, EventArgs e) {
            MergeSortChart.Series.Clear();
            QuickSortChart.Series.Clear();
            CountingSortChart.Series.Clear();
            BinarySearchChart.Series.Clear();
            LinearSearchСhart.Series.Clear();
            InterpolationSearchChart.Series.Clear();
            CountSeries = 0;
            FillArray();
        }
    }
}
