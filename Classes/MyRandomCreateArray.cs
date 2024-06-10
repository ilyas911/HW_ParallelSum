using HW_ParallelSum.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ParallelSum.Classes
{
    public class MyRandomCreateArray: ICreateArray
    {
        public int[] GenerateArrayByIntNumbers(int size)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(100);
            }
            return array;
        }
    }
}
