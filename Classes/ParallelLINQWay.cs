using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    public class ParallelLINQWay: ISumArrayMembers
    {
        public long SumIntMembersFromArray(int[] array)
        {
            return (long)array.AsParallel().Sum();
        }
    }
}
