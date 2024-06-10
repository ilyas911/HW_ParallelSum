using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using HW_ParallelSum.Classes;
using HW_ParallelSum.Interfaces;
class Program
{
    static void Main()
    {
        ICreateArray arrayCreation = new MyRandomCreateArray();
        IOutputInfo outputInfo = new MyOutputInfoConsole();
        IInputData inputData = new MyInputDataConsole();

        int[] array100k = arrayCreation.GenerateArrayByIntNumbers(100000);
        int[] array1m = arrayCreation.GenerateArrayByIntNumbers(1000000);
        int[] array10m = arrayCreation.GenerateArrayByIntNumbers(10000000);

        inputData.InitializeInputThreadsCount();
        int numThreads = inputData.InputThreadsCountWithCheck();

        ISumArrayMembers sequental = new SequentalWay();
        ISumArrayMembers parallelThreads = new ParallelThreadsWay(numThreads);
        ISumArrayMembers parallelLINQ = new ParallelLINQWay();

        outputInfo.OutputMeasureTime("Время выполнения последовательного подсчета (100к)", MeasureTime(() => sequental.SumIntMembersFromArray(array100k)));
        outputInfo.OutputMeasureTime("Время выполнения последовательного подсчета (1м)", MeasureTime(() => sequental.SumIntMembersFromArray(array1m)));
        outputInfo.OutputMeasureTime("Время выполнения последовательного подсчета (10м)", MeasureTime(() => sequental.SumIntMembersFromArray(array10m)));

        outputInfo.OutputMeasureTime("Время выполнения параллельного подсчета (100к)", MeasureTime(() => parallelThreads.SumIntMembersFromArray(array100k)));
        outputInfo.OutputMeasureTime("Время выполнения параллельного подсчета (1м)", MeasureTime(() => parallelThreads.SumIntMembersFromArray(array1m)));
        outputInfo.OutputMeasureTime("Время выполнения параллельного подсчета (10м)", MeasureTime(() => parallelThreads.SumIntMembersFromArray(array10m)));

        outputInfo.OutputMeasureTime("Время выполнения PLINQ (100к)", MeasureTime(() => parallelLINQ.SumIntMembersFromArray(array100k)));
        outputInfo.OutputMeasureTime("Время выполнения PLINQ (1м)", MeasureTime(() => parallelLINQ.SumIntMembersFromArray(array1m)));
        outputInfo.OutputMeasureTime("Время выполнения PLINQ (10м)", MeasureTime(() => parallelLINQ.SumIntMembersFromArray(array10m)));
    }

    static Stopwatch MeasureTime(Action action)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        action();
        stopwatch.Stop();
        return stopwatch;
    }
}

