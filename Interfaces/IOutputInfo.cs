using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Interfaces
{
    public interface IOutputInfo
    {
        void OutputMeasureTime(string method, Stopwatch researchedInfo);
    }
}
