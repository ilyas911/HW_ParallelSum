using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Interfaces
{
    public interface IInputData
    {
        void InitializeInputThreadsCount();
        int InputThreadsCountWithCheck();
    }
}
