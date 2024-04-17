using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace thread5
{
    internal class LinearSearch
    {
        public static int SearchMethod(int[] array, int searchValue,int left, int right) {
            for (int i = left; i < right; i++) {
                if (array[i] == searchValue) return i;
            }
            return -1;
        }

        public static int SequencSearch(int[] array) {
            int searchValue = array.Length - 9999;
            return SearchMethod(array, searchValue,0, array.Length);
        }

        public static int ParallelSearch(int[] array, int countThreads) {
            int searchValue = array.Length - 9999;
            var threads = new List<Task>();
            int result = -1;
            //шаг прибавления
            int step = array.Length / countThreads;
            for (int i = 0; i < countThreads; i++) {
                if (result != -1) return result;
                int left = i * step;
                int right = Math.Min(left + step, array.Length);

                threads.Add(Task.Run(() => {
                    result = SearchMethod(array, searchValue, left, right);
                }));
            }
            Task.WaitAll(threads.ToArray());
            return result;
        }
    }
}
