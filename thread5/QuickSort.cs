using System.Collections.Generic;
using System.Threading.Tasks;

namespace thread5
{
    internal class QuickSort
    {
        private static List<Task> threads;
        //метод для обмена элементов массива
        private static void Swap(ref int a, ref int b) {
            var temp = a;
            a = b;
            b = temp;
        }

        //метод возвращающий индекс опорного элемента
        private static int Partition(int[] array, int left, int right) {
            var pivot = array[right];
            int i = left - 1;
            for (var j = left; j < right; j++) {
                if (array[j] < pivot) {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            i++;
            Swap(ref array[i], ref array[right]);
            return i;
        }

        //последовательная сортировка
        private static int[] SequencSortMethod(int[] array, int left, int right) {
            if (left >= right) {
                return array;
            }

            var pivotIndex = Partition(array, left, right);
            SequencSortMethod(array, left, pivotIndex - 1);
            SequencSortMethod(array, pivotIndex + 1, right);

            return array;
        }

        public static int[] SequencSort(int[] array) {
            return SequencSortMethod(array, 0, array.Length - 1);
        }
        //параллельная сортировка
        private static int[] ParallelSortMethod(int[] array, int left, int right, int countThreads) {
            if (left >= right) {
                return array;
            }

            var pivotIndex = Partition(array, left, right);
            if (countThreads > 0) {
                Parallel.Invoke(
                    () => ParallelSortMethod(array, left, pivotIndex - 1, countThreads - 1),
                    () => ParallelSortMethod(array, pivotIndex + 1, right, countThreads - 1));
            }
            else {
                Task.WaitAll(threads.ToArray());
                ParallelSortMethod(array, left, pivotIndex - 1, 0);
                ParallelSortMethod(array, pivotIndex + 1, right, 0);
            }
            return array;
        }

        public static int[] ParallelSort(int[] array, int countThreads) {
            threads = new List<Task>();
            return ParallelSortMethod(array, 0, array.Length - 1, countThreads);
        }
    }
}
