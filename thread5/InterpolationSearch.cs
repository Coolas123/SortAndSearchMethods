using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace thread5
{
    internal class InterpolationSearch
    {
        private static int InterpolSearch(int[] array, int searchValue, long left, long right) {
            long mid;
            while (array[left] <= searchValue && array[right] >= searchValue) {
                mid = left + (searchValue - array[left]) * (right - left) / (array[right] - array[left]);
                if (array[mid] < searchValue)
                    left = mid + 1;
                else if (array[mid] > searchValue)
                    right = mid - 1;
                else
                    return (int)mid;
            }
            if (array[left] == searchValue)
                return (int)left;
            else if (array[right] == searchValue)
                return (int)right;
            else
                return -1;
        }
        public static int SequencSearch(int[] array) {
            int searchValue = array.Length - 9999;
            int result = InterpolSearch(array, searchValue, 0, array.Length - 1);
            if (result != -1) return result;
            return -1;
        }
        public static int ParallelSearch(int[] array, int countThreads) {
            int searchValue = array.Length - 9999;
            var threads = new List<Task>();
            int result = -1;
            int step = array.Length / countThreads;
            for (int i = 0; i < countThreads; i++) {
                if (result != -1)
                    return result;
                int left = i * step;
                int right = Math.Min(left + step - 1, array.Length - 1);
                threads.Add(Task.Run(() => {
                    result = InterpolSearch(array, left, right, searchValue);
                }));
            }
            return result;
        }

    }
}
