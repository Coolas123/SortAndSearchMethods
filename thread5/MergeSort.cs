using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace thread5
{
    internal class MergeSort
    {
        //метод для слияния массивов
        private static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex) {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex)) {
                if (array[left] < array[right]) {
                    tempArray[index] = array[left];
                    left++;
                }
                else {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++) {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++) {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++) {
                array[lowIndex + i] = tempArray[i];
            }
        }
        //сортировка слиянием
        private static int[] Sort(int[] array, int lowIndex, int highIndex) {
            if (lowIndex < highIndex) {
                var middleIndex = (lowIndex + highIndex) / 2;
                Sort(array, lowIndex, middleIndex);
                Sort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        public static int[] SequencSort(int[] array) {
            return Sort(array, 0, array.Length - 1);
        }

        public static int[] ParallelSort(int[] array, int numThreads) {
            var threads = new List<Task>(numThreads);
            int chunkSize = array.Length / numThreads;
            for (int i = 0; i < numThreads; ++i) {
                int left = i * chunkSize;
                //int right = (i == numThreads - 1) ? array.Length - 1 : left + chunkSize - 1;
                int right = Math.Min(array.Length - 1, left + chunkSize - 1);
                threads.Add(Task.Run(() => Sort(array, left, right)));
            }
            Task.WaitAll(threads.ToArray());

            int step = chunkSize;
            while (step < array.Length) {
                for (int i = 0; i < array.Length - step; i += 2 * step) {
                    int left = i;
                    int mid = i + step - 1;
                    int right = Math.Min(i + 2 * step - 1, array.Length - 1);

                    Merge(array, left, mid, right);
                }
                step *= 2;
            }
            return array;
        }
    }
}
