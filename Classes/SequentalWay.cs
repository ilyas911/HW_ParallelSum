using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    public class SequentalWay: ISumArrayMembers
    {
        public long SumIntMembersFromArray(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
