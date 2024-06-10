using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    internal class MyOutputInfoConsole: IOutputInfo
    {
        public void OutputMeasureTime(string method, Stopwatch researchedInfo)
        {
            Console.WriteLine($"{method} Execution Time: {researchedInfo.Elapsed}");
        }
    }
}
