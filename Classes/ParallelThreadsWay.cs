using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    public class ParallelThreadsWay: ISumArrayMembers
    {
        public int NumberOfThreads { get; set; }
        public ParallelThreadsWay(int numThreads) 
        {
            NumberOfThreads = numThreads;
        }
        public long SumIntMembersFromArray(int[] array)
        {
            long[] partialSums = new long[NumberOfThreads];
            Thread[] threads = new Thread[NumberOfThreads];

            for (int i = 0; i < NumberOfThreads; i++)
            {
                int localIndex = i; // создаем локальную копию переменной для каждого потока
                threads[i] = new Thread(() =>
                {
                    long partialSum = 0;
                    for (int j = localIndex * (array.Length / NumberOfThreads); j < (localIndex + 1) * (array.Length / NumberOfThreads); j++)
                    {
                        partialSum += array[j];
                    }
                    partialSums[localIndex] = partialSum;
                });
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            long totalSum = 0;
            foreach (var partial in partialSums)
            {
                totalSum += partial;
            }
            return totalSum;
        }
    }
}
