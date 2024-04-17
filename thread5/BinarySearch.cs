using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace thread5
{
    internal class BinarySearch
    {
        private static int SearchMethod(int[] array, int searchValue, int left, int right) {
            //левая граница меньше правой
            while (left <= right) {
                //среднее значнеие
                var mid = (left + right) / 2;

                if (searchValue == array[mid]) {
                    return mid;
                }
                else if (searchValue < array[mid]) {
                    //делим попалам
                    right = mid - 1;
                }
                else {
                    //делим попалам
                    left = mid + 1;
                }
            }
            return -1;
        }

        public static int SequencSearch(int[] array) {
            return SearchMethod(array, array.Length-9999,0, array.Length);
        }

        public static int ParallelSearch(int[] array, int countThreads) {
            var threads = new List<Task>(countThreads);
            int result = -1;
            int step= array.Length/countThreads;
            for (int i = 0; i < countThreads; i++) {
                int left = i * step;
                int right = Math.Min(left + step, array.Length);
                threads.Add(Task.Run(() => result = SearchMethod(array, array.Length - 9999,left,right)));
            }
            Task.WaitAll(threads.ToArray());
            return result;
        }
    }
}
