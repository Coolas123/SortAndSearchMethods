using System.Collections.Generic;
using System.Threading.Tasks;

namespace thread5
{
    internal class CountingSort
    {
        public static int[] SequencSort(int[] array) {
            var count = new int[array.Length];
            for (var i = 0; i < array.Length; i++) {
                count[array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++) {
                for (var j = 0; j < count[i]; j++) {
                    array[index] = i;
                    index++;
                }
            }

            return array;
        }

        public static int[] ParallelSort(int[] array, int countThreads) {
            var count = new int[array.Length];
            var threads = new List<Task>(countThreads);
            int step = array.Length / countThreads;
            for (var n = 0; n < array.Length; n += step) {
                threads.Add(Task.Run(() => {
                    for (var i = n; i < n + step; i++) {
                        count[array[i]]++;
                    }
                }));
                Task.WaitAll(threads.ToArray());
            }
            var index = 0;
            for (var i = 0; i < count.Length; i++) {
                for (var j = 0; j < count[i]; j++) {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
    }
}
